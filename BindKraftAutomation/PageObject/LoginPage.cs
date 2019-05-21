using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using BindKraftAutomation.Extensions;
using BindKraftAutomation.TestDataAccess;
using System;
using OpenQA.Selenium.Support.UI;

namespace BindKraftAutomation.PageObject
{
    class LoginPage
    {
        private IWebDriver driver;
        private readonly WebDriverWait wait;

        [FindsBy(How = How.XPath, Using = "//input[@id='Email']")]
        [CacheLookup]
        public IWebElement Email { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='Password']")]
        [CacheLookup]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@class='bk-button bk-button-block bk-margin-bottom-1']")]
        [CacheLookup]
        public IWebElement Submit { get; set; }

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            this.wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(10000));
            PageFactory.InitElements(driver, this);
        }

        public void LoginToApplication(string LogInTest)
        {
            //var userData = ExcelDataAccess.GetTestData(LogInTest);
            //Email.SendKeys(userData.Username);
            //Password.SendKeys(userData.Password);
           
            Email.EnterText( "drake@abv.bg","Email" );
            Password.EnterText("Dsa_123", "Password"); 
            Submit.Submit();
        }

    }
}
