using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using ConsoleApp1.Extensions;
using ConsoleApp1.TestDataAccess;

namespace ConsoleApp1.PageObject
{
    class LoginPage
    {
        private IWebDriver driver;

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
            PageFactory.InitElements(driver, this);
        }

        public void LoginToApplication(string testName)
        {
            var userData = ExcelDataAccess.GetTestData(testName);
            Email.SendKeys(userData.Username);
            Password.SendKeys(userData.Password);
            Submit.Submit();
            //Email.EnterText(userData.Username, "drake@abv.bg");
            //Password.Clear();
            //Password.SendKeys("Dsa_123");
        }

    }
}
