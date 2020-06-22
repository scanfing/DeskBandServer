using System.Windows;
using DeskBandServer.Grpc;
using Grpc.Core;

namespace DeskBandServer.Test
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class GrpcMsgSetView : Window
    {
        #region Fields

        private Channel _channel;
        private DeskBandService.DeskBandServiceClient _client;

        #endregion Fields

        #region Constructors

        public GrpcMsgSetView()
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
                _client = new DeskBandService.DeskBandServiceClient(_channel);
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

        private void BtnSet_Click(object sender, RoutedEventArgs e)
        {
            var request = new ShowTextMessageRequest();
            request.Content = TxtMessage.Text;
            _client.ShowTextMessage(request);
        }

        private void BtnSetColorText_Click(object sender, RoutedEventArgs e)
        {
            var request = new ShowTextMessageRequest();
            var cr = new CustomColor
            {
                A = byte.Parse(Txt_A.Text),
                R = byte.Parse(Txt_R.Text),
                G = byte.Parse(Txt_G.Text),
                B = byte.Parse(Txt_B.Text)
            };
            request.Foreground = cr;
            request.Content = TxtMessage.Text;
            _client.ShowTextMessage(request);
        }

        #endregion Methods
    }
}