using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace TestRepeater.Converters
{
    public class LanguageIsDefaultConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            Visibility result = Visibility.Collapsed;
            switch (value.ToString())
            {
                case "0":
                    result = Visibility.Collapsed;
                    break;
                case "1":
                    result = Visibility.Visible;
                    break;
                default:
                    result = Visibility.Collapsed;
                    break;
            }

            return result;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
