using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace TestRepeater.Helpers
{
    public class EpisodeStringHelper
    {
        /// <summary>
        /// Determine episode show
        /// </summary>
        /// <param name="number"></param>
        /// <param name="total">can be null in xaml, set x:Null</param>
        /// <returns></returns>
        public static string EpisodeConverter(string number, string total = null)
        {
            //P+ first item don't need episode
            if (number == null)
                return "";

            string temp = "";
            Task<string> t = Task.Run( async() =>
            {
                if (total != null)
                {
                    if (number == total.ToString())
                    {
                        temp = "episodes_total";
                        return temp.Replace("%s", total.ToString());
                    }
                    else
                    {
                        temp = "episodes_latest";
                        return temp.Replace("%s", number.ToString());
                    }
                }

                temp = "episode_num";
                return temp.Replace("%s", number.ToString());
            });

            return t.Result;
        }

        public static string EpisodeConverterForHomePage(string number, string categoryName, string synopsis)
        {
            string temp = "";
            Task<string> t = Task.Run(async () =>
            {
                temp = "episode_num";
                temp = categoryName + " | " + temp + "    " + synopsis;
                return temp.Replace("%s", number.ToString());
            });

            return t.Result;
        }

        public static Visibility EpisodeVisibility(int isMovie)
        {
            if (isMovie == 1)
                return Visibility.Collapsed;
            return Visibility.Visible;
        }

        public static Visibility EpisodeVisibility(string isMovie)
        {
            if (isMovie == "1")
                return Visibility.Collapsed;
            return Visibility.Visible;
        }
    }
}
