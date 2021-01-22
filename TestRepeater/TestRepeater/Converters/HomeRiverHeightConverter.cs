using System;
using Windows.UI.Xaml.Data;

namespace TestRepeater.Converters
{
    public class HomeRiverHeightConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            double itemHeight = 0;
            switch (value.ToString())
            {
                case "4":   //movie
                    itemHeight = 420.0;
                    break;
                default:
                    itemHeight = 256.0;
                    break;
            }

            return itemHeight;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
