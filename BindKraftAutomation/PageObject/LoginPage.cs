using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using BindKraftAutomation.Extensions;
using BindKraftAutomation.TestDataAccess;
using System;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using System.Linq;

namespace BindKraftAutomation.PageObject
{
    class LoginPage
    {
        private IWebDriver driver;
        private readonly WebDriverWait wait;

        #region
        [FindsBy(How = How.XPath, Using = "//input[@id='Email']")]
        [CacheLookup]
        public IWebElement Email { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='Password']")]
        [CacheLookup]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@class='bk-button bk-button-block bk-margin-bottom-1']")]
        [CacheLookup]
        public IWebElement Submit { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Forgot your password?')]")]
        [CacheLookup]
        public IWebElement ForgotYourPasswordLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='Email']")]
        [CacheLookup]
        public IWebElement ForgotPass_EnterYourEmail { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@class='bk-button bk-button-block bk-login-button margin-top']")]
        [CacheLookup]
        public IWebElement ForgotPass_Submit { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@class='bk-button bk-button-block']")]
        [CacheLookup]
        public IWebElement CreateAccount_Button { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='FirstName']")]
        [CacheLookup]
        public IWebElement FirstName_Field { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='LastName']")]
        [CacheLookup]
        public IWebElement LastName_Field { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='Email']")]
        [CacheLookup]
        public IWebElement Email_Field { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='Password']")]
        [CacheLookup]
        public IWebElement Password_Field { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='ConfirmPassword']")]
        [CacheLookup]
        public IWebElement ConfirmPassword_Field { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@class='bk-button bk-button-block bk-login-button']")]
        [CacheLookup]
        public IWebElement CreateAccount_SubmitButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='RegisterConsentsViewModel_TermsOfService']")]
        [CacheLookup]
        public IWebElement TermsOfService_CheckBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='RegisterConsentsViewModel_PrivacyPolicy']")]
        [CacheLookup]
        public IWebElement PrivacyPolicy_CheckBox { get; set; }
        #endregion

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            this.wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(10000));
            PageFactory.InitElements(driver, this);
        }

        public void ClickElement(IWebElement el, IWebElement close = null)
        {
            var clickableElement = wait.Until(ExpectedConditions.ElementToBeClickable(el));
            clickableElement.Click();
            if (close != null)
            {
                clickableElement = wait.Until(ExpectedConditions.ElementToBeClickable(close));
                clickableElement.Click();
            }
        }

        public void LoginToApplication(string LogInTest)
        {
            //var userData = ExcelDataAccess.GetTestData(LogInTest);
            //Email.SendKeys(userData.Username);
            //Password.SendKeys(userData.Password);
           
            Email.EnterText( "drake@abv.bg","Email" );
            Assert.AreEqual(Email, Email);
            Password.EnterText("Dsa_123", "Password");
            Assert.AreEqual(Password, Password);
            Submit.Submit();
            Assert.AreEqual(Submit, Submit);
        }

        public void ForgotYourPasword()
        {
            ClickElement(ForgotYourPasswordLink);
            Assert.AreEqual(ForgotYourPasswordLink, ForgotYourPasswordLink);
            ForgotPass_EnterYourEmail.EnterText("drake@abv.bg", "Enter your email");
            Assert.AreEqual(ForgotPass_EnterYourEmail, ForgotPass_EnterYourEmail);
            ClickElement(ForgotPass_Submit);
            Assert.AreEqual(ForgotPass_Submit, ForgotPass_Submit);

            string newTabHandle = driver.WindowHandles.Last();
            var newTab = driver.SwitchTo().Window(newTabHandle);
            var expectedNewTabTitle = "Forgot password confirmation - KraftApps-Authorization";
            Assert.AreEqual(expectedNewTabTitle, newTab.Title);
        }
        //TODO: Kosio
        public void CreateAccount()
        {
            ClickElement(CreateAccount_Button);
            FirstName_Field.EnterText("","");
        }

    }
}
