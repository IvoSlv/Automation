using BindKraftAutomation.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Configuration;
using OpenQA.Selenium.Chrome;
using BindKraftAutomation.Models;

namespace BindKraftAutomation.TestCases
{
    class LogInPageTests : PageTestBase
    {
        private readonly string chromeDriverPath = @"D:\_Development\ChromeDriverOld";

        [Test, Order(10)]
        [Retry(2)]
        public void LoginTest()
        {
            InitDriver();
            this.homePage.GoToLoginPage();

            var loginPage = new LoginPage(driver);
            loginPage.LoginToApplication("LogInTest");

            driver.Dispose();
        }
    }
}
