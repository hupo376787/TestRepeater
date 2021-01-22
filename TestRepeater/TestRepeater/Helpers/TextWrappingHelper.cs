using Windows.UI.Xaml;

namespace TestRepeater.Helpers
{
    public class TextWrappingHelper
    {
        public static TextWrapping GetTextWrapping(int isMovie)
        {
            if (isMovie == 0)
                return TextWrapping.NoWrap;
            else
                return TextWrapping.WrapWholeWords;
        }
    }
}
