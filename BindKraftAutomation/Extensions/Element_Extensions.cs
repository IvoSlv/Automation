using OpenQA.Selenium;

namespace BindKraftAutomation.Extensions
{
    public static class Element_Extensions
    {
        public static void EnterText(this IWebElement element, string text)
        {
            element.Clear();
            element.SendKeys(text);
        }
    }
}
