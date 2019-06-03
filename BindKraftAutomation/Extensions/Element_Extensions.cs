using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace BindKraftAutomation.Extensions
{
    public static class Element_Extensions
    {
        public static Func<IWebElement, string[]> IsDisplayed =
            (element) =>
        {
            string[] result = new string[2];
            result[0] = "true";
            result[1] = "Pass";

            if (!element.Displayed)
            {
                result[0] = "false";
                result[1] = element + "is not Displayed";
            }

            return result;
        };

        public static void EnterText(this IWebElement element, string text)
        {
            element.Clear();
            element.SendKeys(text);
        }

            public static bool Is_Displayed_SimpleAssert(this IWebElement element, string elementName)
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
