using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using BindKraftAutomation.Extensions;
using BindKraftAutomation.TestDataAccess;

namespace BindKraftAutomation.PageObject
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
