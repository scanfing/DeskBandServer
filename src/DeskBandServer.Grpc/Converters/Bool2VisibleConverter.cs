using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace DeskBandServer.Grpc.Converters
{
    public class Bool2VisibleConverter : IValueConverter
    {
        #region Methods

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (bool.TryParse(value?.ToString(), out var flag))
            {
                if (flag)
                {
                    return Visibility.Visible;
                }
                return Visibility.Hidden;
            }
            return Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Visibility visibility)
            {
                return visibility == Visibility.Visible;
            }
            return false;
        }

        #endregion Methods
    }
}