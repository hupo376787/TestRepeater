using Windows.UI.Xaml;

namespace TestRepeater.Helpers.Home
{
    public class HomeCardProgressBarVisibilityHelper
    {
        public static Visibility ProgressBarVisibility(int watched_percent)
        {
            if (watched_percent != 0)
                return Visibility.Visible;

            return Visibility.Collapsed;
        }
    }
}
