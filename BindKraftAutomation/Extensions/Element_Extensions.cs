using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;


namespace BindKraftAutomation.Extensions
{
    public static class Element_Extensions
    {
        
        public static void EnterText(this IWebElement element, string text)
        {
            element.Clear();
            element.SendKeys(text);
        }

        //Example : //myWebElement.WaitUntil(myWebElement =>myWebElement.Displayed).SendKeys("Some Text");
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
