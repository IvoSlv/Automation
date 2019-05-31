using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace BindKraftAutomation.Extensions
{
    public static class Element_Extensions
    {
        public static Func<string, string, int, string[]> Enter_ext =
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
        public static void Enter_Text(this IWebElement element, string text, string elementName)
        {
            element.Clear();
            element.SendKeys(text);
            

        }

        public static void EnterText(this IWebElement element, string text, string elementName)
        {
            element.Clear();
            element.SendKeys(text);
            Console.WriteLine(text + " entered in the " + elementName + " field.");
        }

            public static bool IsDisplayed(this IWebElement element, string elementName)
        {
            bool result;
            try
            {
                result = element.Displayed;
                Console.WriteLine(elementName + " is Displayed.");
            }
            catch (Exception)
            {
                result = false;
                Console.WriteLine(elementName + " is not Displayed.");
            }

            return result;
        }

        public static void ClickOnIt(this IWebElement element, string elementName)
        {
            element.Click();
            Console.WriteLine("Clicked on " + elementName);
        }

        public static void SelectByText(this IWebElement element, string text, string elementName)
        {
            SelectElement oSelect = new SelectElement(element);
            oSelect.SelectByText(text);
            Console.WriteLine(text + " text selected on " + elementName);
        }

        public static void SelectByIndex(this IWebElement element, int index, string elementName)
        {
            SelectElement oSelect = new SelectElement(element);
            oSelect.SelectByIndex(index);
            Console.WriteLine(index + " index selected on " + elementName);
        }

        public static void SelectByValue(this IWebElement element, string text, string elementName)
        {
            SelectElement oSelect = new SelectElement(element);
            oSelect.SelectByValue(text);
            Console.WriteLine(text + " value selected on " + elementName);

        }
    }
}
