using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace BindKraftAutomation.Globals
{
    public static class Helpers
    {
        public static Func<IWebElement, string, string[]> IsDisplayed =
            (element, elName) =>
            {
                string[] result = new string[2];
                result[0] = "true";
                result[1] = "Pass";

                try
                {
                    if (!element.Displayed)
                    {
                        result[0] = "false";
                        result[1] = element + " is not Displayed";
                    }
                }
                catch (Exception ex)
                {
                    result[0] = "false";
                    result[1] = "Error with element: " + elName + ": " + ex.Message;
                }

                return result;
            };

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
