using System;
using System.Globalization;
using System.Linq;
using Xamarin.Forms;

namespace SocialNetwork.Converters
{
    public class IconSourceConverter : IValueConverter
    {
        private const int MyId = 6;

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var arrayIds = (int[])value;

            return arrayIds.ToList().Contains(MyId)
                ? "resource://SocialNetwork.Resources.favorite_on_24dp.svg"
                : "resource://SocialNetwork.Resources.favorite_off_24dp.svg";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Color.FromHex("#FFEDED");
        }
    }
}