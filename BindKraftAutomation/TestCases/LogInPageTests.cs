using BindKraftAutomation.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Configuration;
using OpenQA.Selenium.Chrome;

namespace BindKraftAutomation.TestCases
{
    class LogInPageTests
    {
        private readonly string chromeDriverPath = @"D:\_Development\ChromeDriverOld";

        [Test, Order(10)]
        public void LoginTest()
        {

            IWebDriver driver = new ChromeDriver(chromeDriverPath);
            driver.Url = ConfigurationManager.AppSettings["URL"];

            var homePage = new LandingPage(driver);
            homePage.WindowMaximize();
            homePage.GoToLoginPage();

            var loginPage = new LoginPage(driver);
            loginPage.LoginToApplication("LogInTest");

            driver.Close();
        }
    }
}
