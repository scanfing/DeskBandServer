using System;
using System.Threading.Tasks;
using DeskBandServer.Grpc.Infrastructure;
using DeskBandServer.Grpc.Services;
using Grpc.Core;
using static DeskBandServer.Grpc.DeskBandServiceManager;

namespace DeskBandServer.Grpc
{
    public class DeskBandGrpcManagerImpl : DeskBandServiceManagerBase
    {
        #region Fields

        private LogService _logSrv;
        private DeskBandViewModel _viewModel;

        #endregion Fields

        #region Constructors

        public DeskBandGrpcManagerImpl(DeskBandViewModel viewModel, LogService logSrv)
        {
            _viewModel = viewModel;
            _logSrv = logSrv;
        }

        #endregion Constructors

        #region Methods

        public override Task<ConfigMsgServerReply> ConfigMsgServer(ConfigMsgServerRequest request, ServerCallContext context)
        {
            var reply = new ConfigMsgServerReply();
            var cfg = _viewModel.GetCurrentGrpcConfig();
            if (request.DefaultContent != null)
                cfg.DefaultContent = request.DefaultContent;
            cfg.OnlyAcceptLocalhost = request.OnlyAcceptLocalhost;
            if (request.ServerPort > 0 && request.ServerPort < 65532)
            {
                cfg.ServerPort = request.ServerPort;
            }
            _viewModel.PreSetMsgServerConfig(cfg);
            _logSrv.Log($"Pre Set Grpc Config {cfg.ToJson()}, From {context.Peer}");
            return Task.FromResult(reply);
        }

        public override Task<GetStyleReply> GetStyle(GetStyleRequest request, ServerCallContext context)
        {
            var reply = new GetStyleReply();
            var cfg = _viewModel.CurrentStyleConfig;

            reply.Background = cfg.Background.ToCustom();
            reply.BorderColor = cfg.BorderColor.ToCustom();
            reply.BorderThickness = cfg.BorderThickness;
            reply.CornerRadius = cfg.CornerRadius;
            reply.FontSize = cfg.FontSize;
            reply.Foreground = cfg.Foreground.ToCustom();

            return Task.FromResult(reply);
        }

        public async override Task<SetStyleReply> SetStyle(SetStyleRequest request, ServerCallContext context)
        {
            var reply = new SetStyleReply();
            try
            {
                var cfg = new StyleConfig();
                cfg.Background = request.Background.ToConfig();
                cfg.BorderColor = request.BorderColor.ToConfig();
                cfg.BorderThickness = request.BorderThickness;
                cfg.CornerRadius = request.CornerRadius;
                cfg.FontSize = request.FontSize;
                cfg.Foreground = request.Foreground.ToConfig();

                await _viewModel.ApplyAndSaveStyle(cfg);
                _logSrv.Log($"Apply And Save Style {cfg.ToJson()}, From {context.Peer}");
                reply.Success = true;
            }
            catch (Exception ex)
            {
                reply.Success = false;
                reply.ErrorMsg = ex.Message;
                _logSrv.LogError($"Error When Apply And Save Style From {context.Peer}, {ex.Message}");
            }

            return reply;
        }

        public override Task<StartGrpcMsgServiceReply> StartGrpcMsgService(StartGrpcMsgServiceRequest request, ServerCallContext context)
        {
            var reply = new StartGrpcMsgServiceReply();
            _logSrv.Log($"Request Start Grpc Server , From {context.Peer}");
            try
            {
                _viewModel.StartGrpcServer();
            }
            catch (Exception ex)
            {
                _logSrv.LogError($"Error When Start Grpc Server ,{ex.Message}");
            }

            return Task.FromResult(reply);
        }

        public async override Task<StopGrpcMsgServiceReply> StopGrpcMsgService(StopGrpcMsgServiceRequest request, ServerCallContext context)
        {
            var reply = new StopGrpcMsgServiceReply();
            _logSrv.Log($"Request Stop Grpc Server , From {context.Peer}");
            try
            {
                await _viewModel.StopGrpcServer();
            }
            catch (Exception ex)
            {
                _logSrv.LogError($"Error When Stop Grpc Server ,{ex.Message}");
            }

            return reply;
        }

        #endregion Methods
    }
}