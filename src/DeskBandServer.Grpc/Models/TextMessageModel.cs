using System.Windows.Media;

namespace DeskBandServer.Grpc.Models
{
    public class TextMessageModel : MessageModel
    {
        #region Fields

        private string _content = "--";
        private int _fontSize = 12;
        private Brush _freground = new SolidColorBrush(Colors.White);

        #endregion Fields

        #region Properties

        public string Content
        {
            get => _content;
            set => SetProperty(ref _content, value);
        }

        public int FontSize
        {
            get => _fontSize;
            set => SetProperty(ref _fontSize, value);
        }

        public Brush Foreground
        {
            get => _freground;
            set => SetProperty(ref _freground, value);
        }

        #endregion Properties
    }
}