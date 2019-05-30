using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using BindKraftAutomation.Extensions;
using BindKraftAutomation.TestDataAccess;
using System;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using System.Linq;
using BindKraftAutomation.Models;

namespace BindKraftAutomation.PageObject
{
    class LoginPage : PageTestBase
    {
        
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
        public IWebElement Login { get; set; }

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

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Resend Confirmation')]")]
        [CacheLookup]
        public IWebElement Resend_Confirmation { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='Email']")]
        [CacheLookup]
        public IWebElement ResendConfirmation_EnterYourEmail { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@class='bk-button bk-button-block bk-login-button margin-top']")]
        [CacheLookup]
        public IWebElement ResendConfirmation_Submit { get; set; }

        [FindsBy(How = How.XPath, Using = "//p[@class='bk-font-strong bk-fsize-normal bk-margin-normal'][contains(text(),'KraftBoard')]")]
        [CacheLookup]
        public IWebElement LoginTest_Assert { get; set; }

        [FindsBy(How = How.XPath, Using = "//h2[@class='bk-login-title']")]
        [CacheLookup]
        public IWebElement ForgotPasswodPage_Assert { get; set; }

        [FindsBy(How = How.XPath, Using = "//h2[@class='bk-login-title']")]
        [CacheLookup]
        public IWebElement ResendConfirmationPage_Assert { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Capa_1']")]
        [CacheLookup]
        public IWebElement MicrosoftAccount { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Sign in')]")]
        [CacheLookup]
        public IWebElement MicrosoftAccount_Assert { get; set; }

        [FindsBy(How = How.XPath, Using = "//body[@class='themed']/div[@class='bk-box-primary bk-ffamily-first']/div[contains(@class,'bk-login-form-section')]/section[@class='bk-login-form']/div[@class='center-text']/div[@class='bk-login-external-providers']/form[2]/button[1]/*[1]")]
        [CacheLookup]
        public IWebElement FacebookAccount { get; set; }

        [FindsBy(How = How.Id, Using = "facebook")]
        [CacheLookup]
        public IWebElement FacebookAccount_Assert { get; set; }

        [FindsBy(How = How.XPath, Using = "//body[@class='themed']/div[@class='bk-box-primary bk-ffamily-first']/div[contains(@class,'bk-login-form-section')]/section[@class='bk-login-form']/div[@class='center-text']/div[@class='bk-login-external-providers']/form[1]/button[1]/*[1]")]
        [CacheLookup]
        public IWebElement GoogleAccount { get; set; }

        [FindsBy(How = How.Id, Using = "yDmH0d")]
        [CacheLookup]
        public IWebElement GoogleAccount_Assert { get; set; }
        #endregion

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
            Email.EnterText( "drake@abv.bg","Email" );
            Password.EnterText("Dsa_123", "Password");
            Login.Submit();
            Assert.That(LoginTest_Assert.Text == "KraftBoard", "Login - error");

        }

        public void ForgotYourPasword()
        {
            Assert.That(ForgotYourPasswordLink.Text == "Forgot your password?", "Forgot password link is not working");
            ClickElement(ForgotYourPasswordLink);
            Assert.That(ForgotPasswodPage_Assert.Text == "Forgot your password?", "Forgot password page is not working");
            ForgotPass_EnterYourEmail.EnterText("drake@abv.bg", "Enter your email");
            Assert.That(ForgotPass_Submit.Text == "Submit", "Submit button is not working");
            ClickElement(ForgotPass_Submit);

            string newTabHandle = driver.WindowHandles.Last();
            var newTab = driver.SwitchTo().Window(newTabHandle);
            var expectedNewTabTitle = "Forgot password confirmation - KraftApps-Authorization";
            Assert.AreEqual(expectedNewTabTitle, newTab.Title);
        }
        //TODO: under construction
        public void CreateAccount()
        {
            ClickElement(CreateAccount_Button);
            FirstName_Field.EnterText("","");
        }

        public void ResendConfirmation()
        {
            Assert.That(Resend_Confirmation.Text == "Resend Confirmation", "Resend Confirmation link is not work");
            ClickElement(Resend_Confirmation);
            Assert.That(ResendConfirmationPage_Assert.Text == "Resend confirmation", "Resend Confirmation page error");
            ResendConfirmation_EnterYourEmail.EnterText("drake@abv.bg","Enter your email");
            Assert.That(ResendConfirmation_Submit.Text == "Submit", "Submit button is not working");
            ClickElement(ResendConfirmation_Submit);
            
        }

        public void SignUpWithMicrosoftAcc()
        {
            ClickElement(MicrosoftAccount);
            Assert.That(MicrosoftAccount_Assert.Text == "Sign in", "Microsoft Account link is not working");
        }

        public void SignUpWithFacebookAcc()
        {
            Assert.That(FacebookAccount.Displayed, "Facebook icon is not displayed");
            ClickElement(FacebookAccount);
            Assert.That(FacebookAccount_Assert.Displayed, "Facebook Sign Up page error");
        }

        public void SignUpWithGoogleAcc()
        {
            Assert.That(GoogleAccount.Displayed, "Google icon is not displayed");
            ClickElement(GoogleAccount);
            Assert.That(GoogleAccount_Assert.Displayed, "Google Sign Up page error");
        }

    }
}
