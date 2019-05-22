using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading.Tasks;
using BindKraftAutomation.Extensions;
using System.Linq;
using NUnit.Framework;
using System;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

namespace BindKraftAutomation.PageObject
{
    class HomePage
    {
        private IWebDriver driver;
        private readonly WebDriverWait wait;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            this.wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(10000));
            PageFactory.InitElements(driver, this);
        }

        public void ClickElement(IWebElement el, IWebElement close = null)
        {
            var clickableElement = wait.Until(ExpectedConditions.ElementToBeClickable(el));
            clickableElement.Click();
            if (close != null)
            {
                clickableElement = wait.Until(ExpectedConditions.ElementToBeClickable(close));
                clickableElement.Click();
            }
        }

    }
}
