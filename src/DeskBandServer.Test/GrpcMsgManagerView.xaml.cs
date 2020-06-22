using System.Windows;
using DeskBandServer.Grpc;
using Grpc.Core;

namespace DeskBandServer.Test
{
    /// <summary>
    /// GrpcMsgManagerView.xaml 的交互逻辑
    /// </summary>
    public partial class GrpcMsgManagerView : Window
    {
        #region Fields

        private Channel _channel;
        private DeskBandServiceManager.DeskBandServiceManagerClient _client;

        #endregion Fields

        #region Constructors

        public GrpcMsgManagerView()
        {
            InitializeComponent();
            Btn_Connect_Click(Btn_Connect, new RoutedEventArgs());
        }

        #endregion Constructors

        #region Methods

        private void Btn_Connect_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(Txt_Port.Text, out var port))
            {
                _channel = new Channel(Txt_IP.Text, port, ChannelCredentials.Insecure);
                _client = new DeskBandServiceManager.DeskBandServiceManagerClient(_channel);
                Btn_Connect.IsEnabled = false;
                Btn_DisConnect.IsEnabled = true;
                Txt_IP.IsEnabled = false;
                Txt_Port.IsEnabled = false;
            }
        }

        private async void Btn_DisConnect_Click(object sender, RoutedEventArgs e)
        {
            await _channel.ShutdownAsync();
            _channel = null;
            Btn_DisConnect.IsEnabled = false;
            Btn_Connect.IsEnabled = true;
            Txt_IP.IsEnabled = true;
            Txt_Port.IsEnabled = true;
        }

        private void Btn_Reg_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("Reg.bat");
        }

        private void Btn_UnReg_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("UnReg.bat");
        }

        private async void BtnSet_Click(object sender, RoutedEventArgs e)
        {
            var request = new ConfigMsgServerRequest();
            request.DefaultContent = TxtMessage.Text;
            request.OnlyAcceptLocalhost = ckb_LocalhostOnly.IsChecked.Value;
            request.ServerPort = int.Parse(Txt_MsgPort.Text);

            await _client.ConfigMsgServerAsync(request);
        }

        private async void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            var request = new StartGrpcMsgServiceRequest();
            await _client.StartGrpcMsgServiceAsync(request);
        }

        private async void BtnStop_Click(object sender, RoutedEventArgs e)
        {
            var request = new StopGrpcMsgServiceRequest();
            await _client.StopGrpcMsgServiceAsync(request);
        }

        #endregion Methods
    }
}