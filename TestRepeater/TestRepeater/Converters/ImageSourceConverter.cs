using System;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media.Imaging;

namespace TestRepeater.Converters
{
    public class ImageSourceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            object img = null;
            //is_movie
            switch(value.ToString())
            {
                case "0":
                    img = new BitmapImage(new Uri("ms-appx:///Assets/Slices/首页 电视剧.png"));
                    break;
                case "1":
                    img = new BitmapImage(new Uri("ms-appx:///Assets/Slices/首页 电影.png"));
                    break;
                default:
                    img = new BitmapImage(new Uri("ms-appx:///Assets/Slices/首页 电视剧.png"));
                    break;
            }

            return img;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
