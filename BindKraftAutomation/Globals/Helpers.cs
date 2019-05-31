using System;

namespace BindKraftAutomation.Globals
{
    public static class Helpers
    {
        public static Func<string, string, int, string[]> assertByStartHtml =
        (content, expected, sliceLength) =>
        {
            string[] result = new string[2];
            result[0] = "true";
            result[1] = "Pass";

            var textStart = content.Trim().Substring(0, sliceLength);

            if (textStart != expected)
            {
                result[0] = "false";
                result[1] = textStart + " was different than the expected: " + expected;
            }

            return result;
        };

        
    }
}
