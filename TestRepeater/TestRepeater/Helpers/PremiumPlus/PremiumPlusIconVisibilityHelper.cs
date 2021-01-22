using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace TestRepeater.Helpers.PremiumPlus
{
    public class PremiumPlusIconVisibilityHelper
    {
        /// <summary>
        /// Determines whether show P+ icon or not
        /// </summary>
        /// <param name="user_level"></param>
        /// <returns></returns>
        public static Visibility PremiumPlusIconVisibility(int? user_level)
        {
            if (user_level == null)
                return Visibility.Collapsed;
            else if (user_level == 3)
                return Visibility.Visible;

            return Visibility.Collapsed;
        }

        public static Visibility PremiumPlusIconVisibility(string user_level)
        {
            if (string.IsNullOrEmpty(user_level))
                return Visibility.Collapsed;
            else if (user_level == "3")
                return Visibility.Visible;

            return Visibility.Collapsed;
        }
    }
}
