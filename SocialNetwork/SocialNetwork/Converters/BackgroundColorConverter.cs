using System;
using System.Globalization;
using System.Linq;
using Xamarin.Forms;

namespace SocialNetwork.Converters
{
    public class BackgroundColorConverter : IValueConverter
    {
        private const int MyId = 6;

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var arrayIds = (int[])value;

            return arrayIds.ToList().Contains(MyId)
                ? Color.FromHex("#FFEDED")
                : Color.FromHex("#E6E6E6");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Color.FromHex("#FFEDED");
        }
    }
}