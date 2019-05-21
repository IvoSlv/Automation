using BindKraftAutomation.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Configuration;
using OpenQA.Selenium.Chrome;

namespace BindKraftAutomation
{
    class LandingPageTests
    {
        private readonly string chromeDriverPath = @"D:\_Development\ChromeDriverOld";

        [Test, Order(1)]
        public void GoToLoginPageTest()
        {
            IWebDriver driver = new ChromeDriver(chromeDriverPath);
            driver.Url = ConfigurationManager.AppSettings["URL"];

            var homePage = new LandingPage(driver);
            homePage.WindowMaximize();
            homePage.GoToLoginPage();
            driver.Dispose();
        }

        [Test, Order(2)]
        public void KraftBoardMenuTest()
        {
            IWebDriver driver = new ChromeDriver(chromeDriverPath);
            driver.Url = "https://www.bindkraft.com/en/";
          
            var homePage = new LandingPage(driver);
            homePage.WindowMaximize();
            homePage.KraftBoardMenu();
            driver.Dispose();
        }

        [Test, Order(3)]
        public void KraftBoardPlansMenuTest()
        {
            IWebDriver driver = new ChromeDriver(chromeDriverPath);
            driver.Url = "https://www.bindkraft.com/en/";

            var homePage = new LandingPage(driver);
            homePage.WindowMaximize();
            homePage.KraftBoardPlansMenu();
            driver.Dispose();
        }

        [Test, Order(4)]
        public void KraftCrmMenuTest()
        {
            IWebDriver driver = new ChromeDriver(chromeDriverPath);
            driver.Url = "https://www.bindkraft.com/en/";

            var homePage = new LandingPage(driver);
            homePage.WindowMaximize();
            homePage.KraftCrmMenu();
            homePage.KraftCrmMenu();
            driver.Dispose();
        }

        [Test, Order(5)]
        public void KraftCrmPlansMenuTest()
        {
            IWebDriver driver = new ChromeDriver(chromeDriverPath);
            driver.Url = "https://www.bindkraft.com/en/";

            var homePage = new LandingPage(driver);
            homePage.WindowMaximize();
            homePage.KraftCrmPlansMenu();
            driver.Dispose();
        }

        [Test, Order(6)]
        public void FeaturesMenuTest()
        {
            IWebDriver driver = new ChromeDriver(chromeDriverPath);
            driver.Url = "https://www.bindkraft.com/en/";

            var homePage = new LandingPage(driver);
            homePage.WindowMaximize();
            homePage.FeaturesMenu();
            driver.Dispose();
        }

        [Test, Order(7)]
        public void TermsOfUse_PrivacyPollicyTest()
        {
            IWebDriver driver = new ChromeDriver(chromeDriverPath);
            driver.Url = "https://www.bindkraft.com/en/";

            var homePage = new LandingPage(driver);
            homePage.WindowMaximize();
            homePage.TermsOfUse_PrivacyPollicy();
            driver.Dispose();
        }

        [Test, Order(8)]
        public void Certificate1Test()
        {
            IWebDriver driver = new ChromeDriver(chromeDriverPath);
            driver.Url = "https://www.bindkraft.com/en/";

            var homePage = new LandingPage(driver);
            homePage.WindowMaximize();
            homePage.Certificate1();
            driver.Dispose();  
        }

        [Test, Order(9)]
        public void Certificate2Test()
        {
            IWebDriver driver = new ChromeDriver(chromeDriverPath);
            driver.Url = "https://www.bindkraft.com/en/";

            var homePage = new LandingPage(driver);
            homePage.WindowMaximize();
            homePage.Certificate2();
            driver.Dispose();  
        }
    }
}
