using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using BindKraftAutomation.Extensions;
using BindKraftAutomation.TestDataAccess;
using System;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using System.Linq;
using BindKraftAutomation.Models;
using BindKraftAutomation.Extensions;
using System.Threading.Tasks;

namespace BindKraftAutomation.PageObject
{
    class LoginPage : PageTestBase
    {
        
        private readonly WebDriverWait wait;
        private const int BOOL_INDEX = 0;
        private const int ERR_MSG_INDEX = 1;

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

        [FindsBy(How = How.XPath, Using = "//button[@class='bk-button bk-button-block']")]
        [CacheLookup]
        public IWebElement CreateAccount_Button { get; set; }

        [FindsBy(How = How.XPath, Using = "//h2[@class='bk-login-title']")]
        [CacheLookup]
        public IWebElement CreateAccount_AssertPage { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='RegisterConsentsViewModel_CommunicationConsent']")]
        [CacheLookup]
        public IWebElement InformationAboutKraftApps_CheckBox { get; set; }

        
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
            //Email
            string[] assertTopElements = Element_Extensions.IsDisplayed(Email, "Email");
            bool assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            Email.EnterText( "drake@abv.bg");
            //Password
            assertTopElements = Element_Extensions.IsDisplayed(Password, "Password");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            Password.EnterText("Dsa_123");
            //Login
            Login.Submit();
            Assert.That(LoginTest_Assert.Text == "KraftBoard", "Login - error");
        }

        public void ForgotYourPasword()
        {
            //ForgotYourPasswordLink
            Assert.That(ForgotYourPasswordLink.Text == "Forgot your password?", "Forgot password link is not working");
            ClickElement(ForgotYourPasswordLink);
            //Forgot pass page
            Assert.That(ForgotPasswodPage_Assert.Text == "Forgot your password?", "Forgot password page is not working");
            //Forgot pass field
            string[] assertTopElements = Element_Extensions.IsDisplayed(ForgotPass_EnterYourEmail, "ForgotPass_EnterYourEmail");
            bool assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            ForgotPass_EnterYourEmail.EnterText("drake@abv.bg");
            //Submit
            Assert.That(ForgotPass_Submit.Text == "Submit", "Submit button is not working");
            ClickElement(ForgotPass_Submit);
            //Forgot password confirmation page
            string newTabHandle = driver.WindowHandles.Last();
            var newTab = driver.SwitchTo().Window(newTabHandle);
            var expectedNewTabTitle = "Forgot password confirmation - KraftApps-Authorization";
            Assert.AreEqual(expectedNewTabTitle, newTab.Title, "Forgot password confirmation page error");
        }
        
        public void CreateAccount()
        {
            //Create account button
            Assert.That(CreateAccount_Button.Text == "Create Account", "Create Account Button is not working");
            ClickElement(CreateAccount_Button);
            Assert.That(CreateAccount_AssertPage.Text == "Create Account", "Create Account page error");
            //First name field
            string[] assertTopElements = Element_Extensions.IsDisplayed(FirstName_Field, "FirstName Field");
            bool assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            FirstName_Field.EnterText("John");
            //Last name field
            assertTopElements = Element_Extensions.IsDisplayed(LastName_Field, "LastName Field is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            LastName_Field.EnterText("Spring");
            //Email field 
            assertTopElements = Element_Extensions.IsDisplayed(Email_Field, "Email field is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            Email_Field.EnterText("John@abv.bg");
            //Password field
            assertTopElements = Element_Extensions.IsDisplayed(Password_Field, "Password Field is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            Password_Field.EnterText("Dsa_123");
            //Confirm Pass field
            assertTopElements = Element_Extensions.IsDisplayed(ConfirmPassword_Field, "Confirm Pass Field is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            ConfirmPassword_Field.EnterText("Dsa_123");
            //Info about kraft apps checkbox
            assertTopElements = Element_Extensions.IsDisplayed(InformationAboutKraftApps_CheckBox, "InformationAboutKraftApps_CheckBox is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            ClickElement(InformationAboutKraftApps_CheckBox);
            //Terms Of Service CheckBox
            assertTopElements = Element_Extensions.IsDisplayed(TermsOfService_CheckBox, "TermsOfService_CheckBox is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            ClickElement(TermsOfService_CheckBox);
            //Privacy Policy CheckBox
            assertTopElements = Element_Extensions.IsDisplayed(PrivacyPolicy_CheckBox, "PrivacyPolicy_CheckBox is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            ClickElement(PrivacyPolicy_CheckBox);
            //Create Account Submit Button
            assertTopElements = Element_Extensions.IsDisplayed(CreateAccount_SubmitButton, "CreateAccount_SubmitButton is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
        }

        public void ResendConfirmation()
        {
            //Resend Confirmation link
            Assert.That(Resend_Confirmation.Text == "Resend Confirmation", "Resend Confirmation link is not work");
            ClickElement(Resend_Confirmation);
            //Resend Confirmation page
            Assert.That(ResendConfirmationPage_Assert.Text == "Resend confirmation", "Resend Confirmation page error");
            //Resend Confirmation field
            string[] assertTopElements = Element_Extensions.IsDisplayed(ResendConfirmation_EnterYourEmail, "Resend Confirmation Enter Your Email");
            bool assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            ResendConfirmation_EnterYourEmail.EnterText("drake@abv.bg");
            //Submit
            Assert.That(ResendConfirmation_Submit.Text == "Submit", "Submit button is not working");
            ClickElement(ResendConfirmation_Submit);
            
        }

        public void SignUpWithMicrosoftAcc()
        {
            string[] assertTopElements = Element_Extensions.IsDisplayed(MicrosoftAccount, "Microsoft Account icon is not displayed");
            bool assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            ClickElement(MicrosoftAccount);
            Task.Delay(500).Wait();
            Assert.That(MicrosoftAccount_Assert.Text == "Sign in", "Microsoft Sign Up page error");
        }

        public void SignUpWithFacebookAcc()
        {
            string[] assertTopElements = Element_Extensions.IsDisplayed(FacebookAccount, "Facebook Account icon is not displayed");
            bool assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            ClickElement(FacebookAccount);
            Assert.That(FacebookAccount_Assert.Displayed, "Facebook Sign Up page error");
        }

        public void SignUpWithGoogleAcc()
        {
            string[] assertTopElements = Element_Extensions.IsDisplayed(GoogleAccount, "GoogleAccount icon is not displayed");
            bool assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            ClickElement(GoogleAccount);
            Assert.That(GoogleAccount_Assert.Displayed, "Google Sign Up page error");
        }
        
    }
}
