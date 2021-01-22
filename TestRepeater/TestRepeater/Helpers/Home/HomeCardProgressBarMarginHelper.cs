using Windows.UI.Xaml;

namespace TestRepeater.Helpers.Home
{
    public class HomeCardProgressBarMarginHelper
    {
        public static Thickness ProgressBarMargin()
        {
            //if (DeviceTypeHelper.GetDeviceFormFactorType() == Core.Enums.DeviceFormFactorType.Xbox)
            //    return new Thickness(15, 0, 15, 12);

            return new Thickness(0);
        }
    }
}
