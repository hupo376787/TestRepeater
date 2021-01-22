using Windows.UI.Xaml;

namespace TestRepeater.Helpers.Home
{
    public class HomeCardEpisodeMarginHelper
    {
        public static Thickness EpisodeMargin(int watched_percent)
        {
            //if (watched_percent != 0)
            //{
            //    if(DeviceTypeHelper.GetDeviceFormFactorType() == Core.Enums.DeviceFormFactorType.Xbox)
            //        return new Thickness(15, 0, 0, 18);
            //    else
            //        return new Thickness(0, 0, 0, 6);
            //}

            return new Thickness(0);
        }
    }
}
