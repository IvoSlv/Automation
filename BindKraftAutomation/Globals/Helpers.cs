using System;

namespace BindKraftAutomation.Globals
{
    public static class Helpers
    {
        public static Func<string, string, int, bool> assertByStartHtml =
        (content, expected, sliceLength) =>
        {
            var textStart = content.Trim().Substring(0, sliceLength);

            if (textStart != expected)
            {
                return false;
            }

            return true;
        };
    }
}
