using ConsoleApp1.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Configuration;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Threading;
using System.IO;
using System.Reflection;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.PageObjects;

namespace ConsoleApp1.TestCases
{
    class LogInPageTests
    {
        [Test, Order(8)]
        public void LoginTest()
        {

            IWebDriver driver = new ChromeDriver(@"D:\_Development\ChromeDriverOld");
            driver.Url = ConfigurationManager.AppSettings["URL"];

            var homePage = new HomePage(driver);
            homePage.WindowMaximize();
            homePage.GoToLoginPage();

            var loginPage = new LoginPage(driver);
            loginPage.LoginToApplication("LogInTest");

            driver.Close();
        }
    }
}
