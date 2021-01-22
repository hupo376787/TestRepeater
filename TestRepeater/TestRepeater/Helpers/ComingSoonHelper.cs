using System;
using Windows.UI.Xaml;

namespace TestRepeater.Helpers
{
    public class ComingSoonHelper
    {
        /// <summary>
        /// This function is used in series detail page.
        /// </summary>
        /// <param name="schedule_start_time"></param>
        /// <returns></returns>
        public static Visibility EpisodeCardVisibility(string schedule_start_time)
        {
            try
            {
                if (string.IsNullOrEmpty(schedule_start_time))
                    return Visibility.Collapsed;
                if (schedule_start_time.Equals("0"))
                    return Visibility.Collapsed;

                return Visibility.Visible;
            }
            catch
            {
                return Visibility.Collapsed;
            }

            return Visibility.Collapsed;
        }
    }
}
