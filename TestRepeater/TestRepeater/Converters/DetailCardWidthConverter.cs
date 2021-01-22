using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace TestRepeater.Converters
{
    public class DetailCardWidthConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            //user visible area item count, usually max count is 6
            //When the user is navigating from one edge of the TV screen to the other,
            //it should take no more than six clicks to simplify your UI.
            //Again, the principle of simplicity applies here.
            int numberSeries = 5;
            int numberMovie = 7;
            //item left/right margin = 20, defined in DetailPage.xaml
            int itemLRMargin = 20;
            //river left/right margin = 12, defined in AdaptiveGridView
            int riverMargin = 12;

            double itemWidth = 0;

            //Item ratio
            //movie 2:3
            //series 16:9
            switch (value.ToString())
            {
                case "1":   //movie
                    itemWidth = (Window.Current.CoreWindow.Bounds.Width - riverMargin * 2 - (numberMovie) * itemLRMargin * 2 - 4) / numberMovie;
                    //Debug.WriteLine("itemWidth" + itemWidth);
                    //itemWidth = 192;
                    break;
                default:
                    itemWidth = (Window.Current.CoreWindow.Bounds.Width - riverMargin * 2 - (numberSeries) * itemLRMargin * 2 - 4) / numberSeries;
                    //Debug.WriteLine("itemWidth" + itemWidth);
                    //itemWidth = 288;
                    break;
            }

            return itemWidth;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
