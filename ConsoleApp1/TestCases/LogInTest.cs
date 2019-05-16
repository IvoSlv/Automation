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

namespace ConsoleApp1
{
    
    class LogInTest
    {
        

        [Test, Order(1)]
        public void KraftBoardMenuTest()
        {

            IWebDriver driver = new ChromeDriver(@"D:\_Development\ChromeDriverOld");
            driver.Url = "https://www.bindkraft.com/en/";
          
            var homePage = new HomePage(driver);
            homePage.WindowMaximize();
            homePage.KraftBoardMenu();
            driver.Close();
        }

        [Test, Order(2)]
        public void KraftBoardPlansMenuTest()
        {

            IWebDriver driver = new ChromeDriver(@"D:\_Development\ChromeDriverOld");
            driver.Url = "https://www.bindkraft.com/en/";

            var homePage = new HomePage(driver);
            homePage.WindowMaximize();
            homePage.KraftBoardPlansMenu();
            driver.Close();
        }

        [Test, Order(3)]
        public void KraftCrmMenuTest()
        {

            IWebDriver driver = new ChromeDriver(@"D:\_Development\ChromeDriverOld");
            driver.Url = "https://www.bindkraft.com/en/";

            var homePage = new HomePage(driver);
            homePage.WindowMaximize();
            homePage.KraftCrmMenu();
            driver.Close();
        }

        [Test, Order(4)]
        public void KraftCrmPlansMenuTest()
        {

            IWebDriver driver = new ChromeDriver(@"D:\_Development\ChromeDriverOld");
            driver.Url = "https://www.bindkraft.com/en/";

            var homePage = new HomePage(driver);
            homePage.WindowMaximize();
            homePage.KraftCrmPlansMenu();
            driver.Close();
        }

        [Test, Order(5)]
        public void FeaturesMenuTest()
        {

            IWebDriver driver = new ChromeDriver(@"D:\_Development\ChromeDriverOld");
            driver.Url = "https://www.bindkraft.com/en/";

            var homePage = new HomePage(driver);
            homePage.WindowMaximize();
            homePage.FeaturesMenu();
            driver.Close();
        }

        [Test, Order(6)]
        public void LoginTest()
        {

            IWebDriver driver = new ChromeDriver(@"D:\_Development\ChromeDriverOld");
            driver.Url = ConfigurationManager.AppSettings["URL"];
            //driver.Url = "https://www.bindkraft.com/en/";

            var homePage = new HomePage(driver);
            homePage.WindowMaximize();
            homePage.GoToLoginPage();

            var loginPage = new LoginPage(driver);
            loginPage.LoginToApplication("LogInTest");

            driver.Close();
        }


        
    }
}
