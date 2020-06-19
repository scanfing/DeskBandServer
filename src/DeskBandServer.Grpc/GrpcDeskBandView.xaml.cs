using System;
using System.Runtime.InteropServices;
using System.Windows;
using CSDeskBand;
using CSDeskBand.Wpf;

namespace DeskBandServer.Grpc
{
    [ComVisible(true)]
    [Guid("c1c6a073-ae2b-420b-882c-8fcae8217712")]
    [CSDeskBandRegistration(Name = "GrpcMessage", ShowDeskBand = true)]
    public partial class GrpcDeskBandView : CSDeskBandWpf
    {
        #region Constructors

        public GrpcDeskBandView()
        {
            ViewModel = new DeskBandViewModel(this);
            DataContext = ViewModel;
            InitializeComponent();

            Loaded += GrpcDeskBandView_Loaded;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
        }

        #endregion Constructors

        #region Properties

        public DeskBandViewModel ViewModel { get; private set; }

        #endregion Properties

        #region Methods

        private void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            ViewModel.OnUnHandledException(e);
        }

        private void GrpcDeskBandView_Loaded(object sender, RoutedEventArgs e)
        {
            ViewModel.Start();
        }

        #endregion Methods
    }
}