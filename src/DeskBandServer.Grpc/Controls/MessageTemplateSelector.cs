using System.Windows;
using System.Windows.Controls;
using DeskBandServer.Grpc.Models;

namespace DeskBandServer.Grpc.Controls
{
    public class MessageTemplateSelector : DataTemplateSelector
    {
        #region Constructors

        public MessageTemplateSelector()
        {
        }

        #endregion Constructors

        #region Properties

        public DataTemplate TextMessage { get; set; }

        #endregion Properties

        #region Methods

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item is TextMessageModel)
            {
                return TextMessage;
            }
            return base.SelectTemplate(item, container);
        }

        #endregion Methods
    }
}