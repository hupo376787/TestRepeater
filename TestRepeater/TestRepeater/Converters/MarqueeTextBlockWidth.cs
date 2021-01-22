using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace TestRepeater.Converters
{
    public class MarqueeTextBlockWidth : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            double width = 0;
            //is_movie
            switch (value.ToString())
            {
                case "0":
                    width = 280;
                    break;
                case "1":
                    width = 180;
                    break;
                default:
                    break;
            }

            return width;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
