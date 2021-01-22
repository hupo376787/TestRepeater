using System;
using Windows.UI.Xaml.Data;

namespace TestRepeater.Converters
{
    public class ColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            string hex = "";
            //FFBF00

            hex = "#" + value.ToString();

            //#FFBF00
            return hex;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
