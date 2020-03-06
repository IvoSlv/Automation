using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;


namespace BindKraftAutomation.Extensions
{
    public static class Element_Extensions
    {

        /// <summary>
        /// Clear and Enter Text
        /// </summary>
        /// <param name="element">Main element to enter text</param>
        /// <param name="text">The text who have to put in the field</param>
        ///
        public static void EnterText(this IWebElement element, string text)
        {
            element.Clear();
            element.SendKeys(text);
        }

        /// <summary>
        /// Fluent Wait
        /// </summary>
        /// <param name="element">Main element for wait</param>
        /// <param name="condition">Expected Condition</param>
        ///

        ///Example : myWebElement.IWaitForElemen(myWebElement =>myWebElement.Displayed).SendKeys("Some Text");
        public static IWebElement IWaitForElement(this IWebElement element, Func<IWebElement, bool> condition)
        {
            IWait<IWebElement> wait = new DefaultWait<IWebElement>(element);
            wait.Timeout = TimeSpan.FromSeconds(30);
            wait.PollingInterval = TimeSpan.FromMilliseconds(500);
            wait.Until(condition);
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            return element;         
        }
        
       



    }
}
