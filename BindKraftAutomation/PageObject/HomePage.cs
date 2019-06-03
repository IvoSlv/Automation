using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using NUnit.Framework;
using System;
using OpenQA.Selenium.Support.UI;
using BindKraftAutomation.Models;
using BindKraftAutomation.Extensions;

namespace BindKraftAutomation.PageObject
{
    class HomePage : PageTestBase
    {
        private readonly WebDriverWait wait;
        private const int BOOL_INDEX = 0;
        private const int ERR_MSG_INDEX = 1;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            this.wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(10000));
            PageFactory.InitElements(driver, this);
        }

        #region
        [FindsBy(How = How.XPath, Using = "//p[@class='bk-font-strong bk-fsize-normal bk-margin-normal'][contains(text(),'KraftCRM')]")]
        [CacheLookup]
        public IWebElement KraftCrm { get; set; }

        [FindsBy(How = How.XPath, Using = "//p[@class='bk-font-strong bk-fsize-normal bk-margin-normal'][contains(text(),'KraftBoard')]")]
        [CacheLookup]
        public IWebElement KraftBoard { get; set; }

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]")]
        [CacheLookup]
        public IWebElement UserOption_Menu { get; set; }

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/*")]
        [CacheLookup]
        public IWebElement HomePage_Menu { get; set; }

        [FindsBy(How = How.XPath, Using = "//p[@class='bk-font-strong bk-fsize-normal bk-margin-normal'][contains(text(),'KraftHRM')]")]
        [CacheLookup]
        public IWebElement KraftHrm { get; set; }

        [FindsBy(How = How.XPath, Using = "//h1[contains(text(),'Kraft Board')]")]
        [CacheLookup]
        public IWebElement KraftBoard_Assert { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'User profile')]")]
        [CacheLookup]
        public IWebElement UserProfile { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Edit')]")]
        [CacheLookup]
        public IWebElement UserProfile_Edit { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'First Name')]")]
        [CacheLookup]
        public IWebElement UserProfile_FirstName { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Last Name')]")]
        [CacheLookup]
        public IWebElement UserProfile_LastName { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Subscribe for our newsletter')]")]
        [CacheLookup]
        public IWebElement UserProfile_Subscribe { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Last login date')]")]
        [CacheLookup]
        public IWebElement UserProfile_LastLoginDate { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Save')]")]
        [CacheLookup]
        public IWebElement UserProfile_SaveButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Cancel')]")]
        [CacheLookup]
        public IWebElement UserProfile_CancelButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Delete')]")]
        [CacheLookup]
        public IWebElement UserProfile_DeleteButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(@class,'bk-interact bk-pushable bk-svg-main bk-margin-normal')]//*[@id='Layer_1']")]
        [CacheLookup]
        public IWebElement UserProfile_CloseButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='bk-field']//div//input")]
        [CacheLookup]
        public IWebElement UserProfile_SubscribeCheckBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='bk-svg-main-oposit hamburger-button']")]
        [CacheLookup]
        public IWebElement HamburgerMenuBotton { get; set; }

        [FindsBy(How = How.XPath, Using = "//h1[contains(text(),'Kraft CRM')]")]
        [CacheLookup]
        public IWebElement KraftCrm_AssertPage { get; set; }

        [FindsBy(How = How.XPath, Using = "//h1[contains(text(),'Kraft HRM')]")]
        [CacheLookup]
        public IWebElement KraftHrm_AssertPage { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class='bk-svg-nochshell']//*[@id='Layer_1']")]
        [CacheLookup]
        public IWebElement NotificationIcon { get; set; }

        [FindsBy(How = How.XPath, Using = "//p[@class='bk-color-text']")]
        [CacheLookup]
        public IWebElement NotificationMenu_Assert { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='header-icons']//div[2]")]
        [CacheLookup]
        public IWebElement KraftUsersGuideIcon { get; set; }

        [FindsBy(How = How.XPath, Using = "//h2[contains(text(),'Kraft CRM Users guide')]")]
        [CacheLookup]
        public IWebElement KraftUsersGuidePage_Assert { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Notification settings')]")]
        [CacheLookup]
        public IWebElement NotificationSettings { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Logout')]")]
        [CacheLookup]
        public IWebElement Logout_Button { get; set; }

        [FindsBy(How = How.XPath, Using = "//h2[@class='bk-login-title']")]
        [CacheLookup]
        public IWebElement Logout_AfterClickLogout_Assert { get; set; }
        #endregion

        public void GoToCrm()
        {
            Assert.That(KraftCrm.Text == "KraftCRM", "KraftCRM is not displayed");
            ClickElement(KraftCrm);
            Assert.That(KraftCrm_AssertPage.Text == "Kraft CRM", "KraftCRM page error");
        }
        
        public void GoToBoard()
        {
            Assert.That(KraftBoard.Text == "KraftBoard", "KraftBoard is not displayed");
            ClickElement(KraftBoard);
            Assert.That(KraftBoard_Assert.Text == "Kraft Board", "KraftBoard page error");
        }
        
        public void GoToHrm()
        {
            Assert.That(KraftHrm.Text == "KraftHRM", "KraftHRM is not displayed");
            ClickElement(KraftHrm);
            Assert.That(KraftHrm_AssertPage.Text == "Kraft HRM", "KraftHRM  page error");
        }
        
        public void OpenUserOptionMenu()
        {
            string[] assertTopElements = Element_Extensions.IsDisplayed(UserOption_Menu);
            bool assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            ClickElement(UserOption_Menu);
            Assert.That(NotificationSettings.Text == "Notification settings", "Users option window error");
        }
        // Under construction
        public void OpenUserProfile()
        {
            ClickElement(UserOption_Menu);
            ClickElement(UserProfile);
            Assert.AreEqual(UserProfile, UserProfile);
        }
        // Under construction
        public void CheckUserProfileInfo()
        {
            ClickElement(UserOption_Menu);
            ClickElement(UserProfile);
            Assert.AreEqual(UserProfile_FirstName, UserProfile_FirstName);
            Assert.AreEqual(UserProfile_LastName, UserProfile_LastName);
            Assert.AreEqual(UserProfile_Subscribe, UserProfile_Subscribe);
            Assert.AreEqual(UserProfile_LastLoginDate, UserProfile_LastLoginDate);
        }
        // Under construction
        public void CheckUserProfileButtons()
        {
            ClickElement(UserOption_Menu);
            ClickElement(UserProfile);
            ClickElement(UserProfile_Edit);
            Assert.AreEqual(UserProfile, UserProfile);
            ClickElement(UserProfile_CancelButton);
            Assert.AreEqual(UserProfile_CancelButton, UserProfile_CancelButton);
            ClickElement(UserProfile_Edit);
            ClickElement(UserProfile_SubscribeCheckBox, UserProfile_SubscribeCheckBox);
            Assert.AreEqual(UserProfile_SubscribeCheckBox, UserProfile_SubscribeCheckBox);
            ClickElement(UserProfile_SaveButton);
            Assert.AreEqual(UserProfile_SaveButton, UserProfile_SaveButton);
        }
        // Under construction
        public void OpenHamburgerMenuBotton()
        {
            ClickElement(HamburgerMenuBotton);
        }

        public void CheckNotificationMenu()
        {
            string[] assertTopElements = Element_Extensions.IsDisplayed(NotificationIcon);
            bool assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            ClickElement(NotificationIcon);
            Assert.That(NotificationMenu_Assert.Text == "Notifications", "Notification window error");
        }

        public void GoToKraftUsersGuide()
        {
            string[] assertTopElements = Element_Extensions.IsDisplayed(KraftUsersGuideIcon);
            bool assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            ClickElement(KraftUsersGuideIcon);
            Assert.That(KraftUsersGuidePage_Assert.Text == "Kraft CRM Users guide", "Kraft Users guide page error");
        }

        public void Logout()
        {
            // Open user option menu
            string[] assertTopElements = Element_Extensions.IsDisplayed(UserOption_Menu);
            bool assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            ClickElement(UserOption_Menu);
            // Click Logout button
            Assert.That(Logout_Button.Text == "Logout", "Logout button is not working");
            ClickElement(Logout_Button);
            Assert.That(Logout_AfterClickLogout_Assert.Text == "Log in", "Login page error, after click Logout button");
        }
    }
}
