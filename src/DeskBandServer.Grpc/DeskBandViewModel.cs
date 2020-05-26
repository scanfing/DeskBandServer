using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Threading;
using DeskBandServer.Grpc.Infrastructure;
using DeskBandServer.Grpc.Models;
using DeskBandServer.Grpc.Services;
using Grpc.Core;

namespace DeskBandServer.Grpc
{
    public class DeskBandViewModel : ViewModelBase
    {
        #region Fields

        private Brush _background;
        private Brush _borderBrush;
        private Thickness _borderThickness = new Thickness(0);
        private ConfigService _cfgSrv;
        private CornerRadius _cornerRadius = new CornerRadius(5);
        private Brush _defaultForeground = new SolidColorBrush(Colors.White);
        private DeskBandGrpcServiceImpl _deskBandService;
        private Dispatcher _dispatcher;
        private int _fontSize;
        private Server _grpcMsgServer;

        private LogService _logSrv;
        private Server _mgrServer;
        private MessageModel _msg;
        private GrpcConfig _msgSrvCfg;
        private GrpcDeskBandView _view;

        #endregion Fields

        #region Constructors

        public DeskBandViewModel(GrpcDeskBandView view)
        {
            _view = view;
            _dispatcher = view.Dispatcher;

            _logSrv = new LogService();
            _logSrv.Clear();

            _cfgSrv = new ConfigService();
            _msgSrvCfg = _cfgSrv.LoadConfig<GrpcConfig>();
            _deskBandService = new DeskBandGrpcServiceImpl(this, _logSrv);
        }

        #endregion Constructors

        #region Properties

        public Brush Background
        {
            get => _background;
            set => SetProperty(ref _background, value);
        }

        public Brush BorderBrush
        {
            get => _borderBrush;
            set => SetProperty(ref _borderBrush, value);
        }

        public Thickness BorderThickness
        {
            get => _borderThickness;
            set => SetProperty(ref _borderThickness, value);
        }

        public CornerRadius CornerRadius
        {
            get => _cornerRadius;
            set => SetProperty(ref _cornerRadius, value);
        }

        public StyleConfig CurrentStyleConfig { get; private set; }

        public int FontSize
        {
            get => _fontSize;
            set => SetProperty(ref _fontSize, value);
        }

        public Brush Foreground
        {
            get => _defaultForeground;
            private set => SetProperty(ref _defaultForeground, value);
        }

        public MessageModel MsgModel
        {
            get => _msg;
            private set => SetProperty(ref _msg, value);
        }

        #endregion Properties

        #region Methods

        public async Task ApplyAndSaveStyle(StyleConfig cfg)
        {
            await ApplyStyle(cfg);
            _cfgSrv.SaveConfig(cfg);
        }

        public GrpcConfig GetCurrentGrpcConfig()
        {
            var cfg = new GrpcConfig();
            cfg.DefaultContent = _msgSrvCfg.DefaultContent;
            cfg.OnlyAcceptLocalhost = _msgSrvCfg.OnlyAcceptLocalhost;
            cfg.ServerPort = _msgSrvCfg.ServerPort;

            return cfg;
        }

        public async Task<Size> GetDeskBandSize()
        {
            var size = await _dispatcher.InvokeAsync(() =>
             {
                 var realSize = new Size(_view.ActualWidth, _view.ActualHeight);
                 return realSize;
             });

            return size;
        }

        public void OnUnHandledException(UnhandledExceptionEventArgs e)
        {
            _logSrv.LogError("UnhandledException: " + e.ExceptionObject);
            if (e.IsTerminating)
            {
                StopGrpcServer().Wait();
            }
        }

        /// <summary>
        /// 预设消息服务的配置（保存到json）
        /// </summary>
        /// <param name="cfg"></param>
        public void PreSetMsgServerConfig(GrpcConfig cfg)
        {
            _cfgSrv.SaveConfig(cfg);
        }

        public void SetMessage(string content)
        {
            _dispatcher.Invoke(() =>
            {
                var txtModel = new TextMessageModel
                {
                    FontSize = FontSize,
                    Foreground = Foreground,
                    Content = content
                };
                MsgModel = txtModel;
            });
        }

        public void SetMessage(string content, Color cr)
        {
            _dispatcher.Invoke(() =>
            {
                if (MsgModel is TextMessageModel txtModel)
                { }
                else
                {
                    txtModel = new TextMessageModel();
                }
                txtModel.Content = content;
                txtModel.Foreground = new SolidColorBrush(cr);
                txtModel.FontSize = FontSize;
                MsgModel = txtModel;
            });
        }

        public async void Start()
        {
            await InitStyle();
            MsgModel = new TextMessageModel()
            {
                Content = _msgSrvCfg.DefaultContent,
                FontSize = FontSize,
                Foreground = Foreground
            };
            StartManagerServerIfNeed();
            StartGrpcServer();
        }

        public void StartGrpcServer()
        {
            if (_grpcMsgServer != null)
                return;
            _msgSrvCfg = _cfgSrv.LoadConfig<GrpcConfig>();
            var ip = "0.0.0.0";
            if (_msgSrvCfg.OnlyAcceptLocalhost)
            {
                ip = "127.0.0.1";
            }
            var srvPort = new ServerPort(ip, _msgSrvCfg.ServerPort, ServerCredentials.Insecure);
            _grpcMsgServer = new Server
            {
                Services = { DeskBandService.BindService(_deskBandService) },
                Ports = { srvPort }
            };
            _logSrv.Log($"Grpc Msg Server Start At : {_msgSrvCfg.ServerPort}");
            _grpcMsgServer.Start();
        }

        public async Task StopGrpcServer()
        {
            if (_grpcMsgServer == null)
                return;

            await _grpcMsgServer.ShutdownAsync();
            _grpcMsgServer = null;
            _logSrv.Log($"Grpc Msg Server Stoped.");
        }

        private async Task ApplyStyle(StyleConfig cfg)
        {
            await _dispatcher.InvokeAsync(() =>
             {
                 var brdColor = Color.FromArgb(cfg.BorderColor.A, cfg.BorderColor.R, cfg.BorderColor.G, cfg.BorderColor.B);
                 BorderBrush = new SolidColorBrush(brdColor);

                 var backcolor = Color.FromArgb(cfg.Background.A, cfg.Background.R, cfg.Background.G, cfg.Background.B);
                 Background = new SolidColorBrush(backcolor);

                 var forecolor = Color.FromArgb(cfg.Foreground.A, cfg.Foreground.R, cfg.Foreground.G, cfg.Foreground.B);
                 Foreground = new SolidColorBrush(forecolor);

                 BorderThickness = new Thickness(cfg.BorderThickness);
                 CornerRadius = new CornerRadius(cfg.CornerRadius);
                 FontSize = (int)cfg.FontSize;
             });
            CurrentStyleConfig = cfg;
        }

        private async Task InitStyle()
        {
            var cfg = _cfgSrv.LoadConfig<StyleConfig>();
            await ApplyStyle(cfg);
        }

        private void StartManagerServerIfNeed()
        {
            var cfg = _cfgSrv.LoadConfig<SysConfig>();
            if (cfg.EnableGrpcManager)
            {
                var ip = "127.0.0.1";
                var srvPort = new ServerPort(ip, cfg.ManagePort, ServerCredentials.Insecure);
                _mgrServer = new Server
                {
                    Services = { DeskBandServiceManager.BindService(new DeskBandGrpcManagerImpl(this, _logSrv)) },
                    Ports = { srvPort }
                };
                _mgrServer.Start();
                _logSrv.Log($"Manager Server Start At : {cfg.ManagePort}");
            }
        }

        #endregion Methods
    }
}