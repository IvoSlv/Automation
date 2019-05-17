using BindKraftAutomation.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Configuration;
using OpenQA.Selenium.Chrome;

namespace BindKraftAutomation.TestCases
{
    class LogInPageTests
    {
        [Test, Order(8)]
        public void LoginTest()
        {

            IWebDriver driver = new ChromeDriver(@"D:\_Development\ChromeDriverOld");
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
