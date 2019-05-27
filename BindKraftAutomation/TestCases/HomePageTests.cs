using BindKraftAutomation.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Configuration;
using OpenQA.Selenium.Chrome;
using BindKraftAutomation.Models;

namespace BindKraftAutomation.TestCases
{
    class HomePageTests : PageTestBase
    {
        [Test, Order(13)]
        [Retry(2)]
        public void GoToBoardTest()
        {
            InitDriver();
            this.homePage.GoToLoginPage();

            var loginPage = new LoginPage(driver);
            loginPage.LoginToApplication("LogInTest");

            var HomePage = new HomePage(driver);
            HomePage.GoToBoard();

            CloseAllDrivers();
        }
    }
}
