using System;
using System.Globalization;
using Xamarin.Forms;

namespace SocialNetwork.Converters
{
    public class VisibleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return System.Convert.ToUInt32(value) > 0;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return System.Convert.ToUInt32(value) > 0;
        }
    }
}