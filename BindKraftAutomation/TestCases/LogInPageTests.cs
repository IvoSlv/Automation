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

        [Test, Order(11)]
        [Retry(2)]
        public void ForgotYourEmailTest()
        {
            InitDriver();
            this.homePage.GoToLoginPage();

            var loginPage = new LoginPage(driver);
            loginPage.ForgotYourPasword();

            driver.Dispose();
        }
    }
}
