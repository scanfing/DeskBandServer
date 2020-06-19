using System.Windows;

namespace DeskBandServer.Test
{
    /// <summary>
    /// Shell.xaml 的交互逻辑
    /// </summary>
    public partial class Shell : Window
    {
        #region Fields

        private Window _managerView;

        private Window _MsgView;

        #endregion Fields

        #region Constructors

        public Shell()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region Methods

        private void ShowManagerView(object sender, RoutedEventArgs e)
        {
            if (_managerView == null)
            {
                _managerView = new GrpcMsgManagerView
                {
                    Owner = this
                };
                _managerView.Closing += (o, ee) =>
                {
                    _managerView.Hide();
                    ee.Cancel = true;
                };
            }
            _managerView.Show();
        }

        private void ShowMsgSetView(object sender, RoutedEventArgs e)
        {
            if (_MsgView == null)
            {
                _MsgView = new GrpcMsgSetView
                {
                    Owner = this
                };
                _MsgView.Closing += (o, ee) =>
                {
                    _MsgView.Hide();
                    ee.Cancel = true;
                };
            }
            _MsgView.Show();
        }

        private void Window_Closed(object sender, System.EventArgs e)
        {
            Application.Current.Shutdown();
        }

        #endregion Methods
    }
}