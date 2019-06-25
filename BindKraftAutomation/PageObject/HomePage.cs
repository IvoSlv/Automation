using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using NUnit.Framework;
using System;
using OpenQA.Selenium.Support.UI;
using BindKraftAutomation.Models;
using BindKraftAutomation.Extensions;
using System.Threading.Tasks;

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
        public IWebElement NotificationSettings_Button { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Logout')]")]
        [CacheLookup]
        public IWebElement Logout_Button { get; set; }

        [FindsBy(How = How.XPath, Using = "//h2[@class='bk-login-title']")]
        [CacheLookup]
        public IWebElement Logout_AfterClickLogout_Assert { get; set; }

        [FindsBy(How = How.XPath, Using = "//body//div[@class='bk-form']//div[@class='bk-form']//div//div[1]//input[1]")]
        [CacheLookup]
        public IWebElement NotificationSettings_BoardCheckBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//body//div[@class='bk-form']//div[@class='bk-form']//div//div[2]//input[1]")]
        [CacheLookup]
        public IWebElement NotificationSettings_CrmCheckBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//body/div[@id='bindkraft']/div[@id='container']/div[contains(@class,'bk-ffamily-third')]/div[@class='bk-client-position']/div[@class='bk-simplewindow ui-draggable window_active']/div[@class='bk-client-position f_view_container']/div[@class='bk-form']/div/div[@class='bk-form']/div[1]/input[1]")]
        [CacheLookup]
        public IWebElement NotificationSettings_DecktopCheckBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//body/div[@id='bindkraft']/div[@id='container']/div[contains(@class,'bk-ffamily-third')]/div[@class='bk-client-position']/div[@class='bk-simplewindow ui-draggable window_active']/div[@class='bk-client-position f_view_container']/div[@class='bk-form']/div/div[@class='bk-form']/div[2]/input[1]")]
        [CacheLookup]
        public IWebElement NotificationSettings_InAppCheckBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class='bk-windowtitle']")]
        [CacheLookup]
        public IWebElement NotificationSettings_WindowAssert { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(@class,'bk-button bk-button-small')]")]
        [CacheLookup]
        public IWebElement NotificationSettings_SaveButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//h4[contains(text(),'Subscribe for Applications:')]")]
        [CacheLookup]
        public IWebElement NotificationSettings_SubscribeForApplicationText { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Board')]")]
        [CacheLookup]
        public IWebElement NotificationSettings_BoardText { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'CRM')]")]
        [CacheLookup]
        public IWebElement NotificationSettings_CrmText { get; set; }

        [FindsBy(How = How.XPath, Using = "//h4[contains(text(),'Receive notifications through:')]")]
        [CacheLookup]
        public IWebElement NotificationSettings_ReceiveNotificationsThroughText { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Desktop')]")]
        [CacheLookup]
        public IWebElement NotificationSettings_DesktopText { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'In-App')]")]
        [CacheLookup]
        public IWebElement NotificationSettings_InAppText { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class='bk-windowtitle']")]
        [CacheLookup]
        public IWebElement UserProfileMenu_WindowAssert { get; set; }

        [FindsBy(How = How.XPath, Using = "//p[@class='text-apps-startmenu'][contains(text(),'KraftBoard')]")]
        [CacheLookup]
        public IWebElement HamburgerMenu_KraftBoardLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//p[@class='text-apps-startmenu'][contains(text(),'KraftCRM')]")]
        [CacheLookup]
        public IWebElement HamburgerMenu_KraftCrmLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//p[@class='text-apps-startmenu'][contains(text(),'KraftHRM')]")]
        [CacheLookup]
        public IWebElement HamburgerMenu_KraftHrmLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Home')]")]
        [CacheLookup]
        public IWebElement HamburgerMenu_HomeLink { get; set; }

        [FindsBy(How = How.XPath, Using = "///span[contains(@class,'bk-svg-arrow-menu')]//*[@id='Layer_1']")]
        [CacheLookup]
        public IWebElement HamburgerMenu_ArrowSvg { get; set; }
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
            string[] assertTopElements = Element_Extensions.IsDisplayed(UserOption_Menu, "UserOption_Menu");
            bool assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            ClickElement(UserOption_Menu);
            Assert.That(NotificationSettings_Button.Text == "Notification settings", "Users option window error");
        }
        
        public void UserProfileMenu()
        {
            // Check items
            ClickElement(UserOption_Menu);
            Assert.That(UserProfile.Text == "User profile", "User profile button is not displayed");
            ClickElement(UserProfile);
            Assert.That(UserProfileMenu_WindowAssert.Text == "User Profile", "User profile window is not displayed");
            Assert.That(UserProfile_FirstName.Text == "First Name", " 'First Name' is not displayed");
            Assert.That(UserProfile_LastName.Text == "Last Name", " 'Last name' is not displayed");
            Assert.That(UserProfile_Subscribe.Text == "Subscribe for our newsletter", "'Subscribe for our newsletter' is not displayed");
            Assert.That(UserProfile_LastLoginDate.Text == "Last login date", " 'Last login date' is not displayed");
            //Delete button
            Assert.That(UserProfile_DeleteButton.Text == "Delete", " 'Delete' button is not displayed");
            //Close button 
            string[] assertTopElements = Element_Extensions.IsDisplayed(UserProfile_CloseButton, "UserProfile_CloseButton");
            bool assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            //Edit button
            Assert.That(UserProfile_Edit.Text == "Edit", " 'Edit' button is not displayed");
            ClickElement(UserProfile_Edit);
            //Subscribe for our newsletter check box
            assertTopElements = Element_Extensions.IsDisplayed(UserProfile_SubscribeCheckBox, "UserProfile_SubscribeCheckBox");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            ClickElement(UserProfile_SubscribeCheckBox);
            //Cancel button
            Assert.That(UserProfile_CancelButton.Text == "Cancel", " 'Cancel' button is not displayed");
            ClickElement(UserProfile_CancelButton, UserProfile_Edit);
            //Save button
            Assert.That(UserProfile_SaveButton.Text == "Save", " 'Save' button is not displayed");
            ClickElement(UserProfile_SaveButton);

        }
        
        
        public void HamburgerMenu()
        {
            string[] assertTopElements = Element_Extensions.IsDisplayed(HamburgerMenuBotton, "HamburgerMenuBotton");
            bool assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            ClickElement(HamburgerMenuBotton);
            //Check items
            Task.Delay(300).Wait();
            Assert.That(HamburgerMenu_KraftBoardLink.Text == "KraftBoard", "KraftBoard link is not displayed");
            Assert.That(HamburgerMenu_KraftCrmLink.Text == "KraftCRM", "KraftCRM link is not displayed");
            Assert.That(HamburgerMenu_KraftHrmLink.Text == "KraftHRM", "KraftHRM link is not displayed");
            Assert.That(HamburgerMenu_HomeLink.Text == "Home", "Home link is not displayed");
        }

        public void HamburgerMenu_GoToKraftBoard()
        {
            ClickElement(HamburgerMenuBotton);
            Task.Delay(300).Wait();
            ClickElement(HamburgerMenu_KraftBoardLink);
            Assert.That(KraftBoard_Assert.Text == "Kraft Board", "KraftBoard button is not working");
        }

        public void HamburgerMenu_GoToKraftCrm()
        {
            ClickElement(HamburgerMenuBotton);
            Task.Delay(300).Wait();
            ClickElement(HamburgerMenu_KraftCrmLink);
            Assert.That(KraftCrm_AssertPage.Text == "Kraft CRM", "KraftCRM button is not working");
        }

        public void HamburgerMenu_GoToKraftHrm()
        {
            ClickElement(HamburgerMenuBotton);
            Task.Delay(300).Wait();
            ClickElement(HamburgerMenu_KraftHrmLink);
            Assert.That(KraftHrm_AssertPage.Text == "Kraft HRM", "KraftHRM button is not working");
        }

        public void HamburgerMenu_ClickHomeButton()
        {
            ClickElement(KraftCrm);
            ClickElement(HamburgerMenuBotton);
            Task.Delay(300).Wait();
            ClickElement(HamburgerMenu_HomeLink);
            Assert.That(KraftHrm.Text == "KraftHRM", "Home button is not working");
        }

        public void CheckNotificationMenu()
        {
            Task.Delay(500).Wait();
            string[] assertTopElements = Element_Extensions.IsDisplayed(NotificationIcon, "NotificationIcon");
            bool assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            ClickElement(NotificationIcon);
            Assert.That(NotificationMenu_Assert.Text == "Notifications", "Notification window error");
        }

        public void GoToKraftUsersGuide()
        {
            string[] assertTopElements = Element_Extensions.IsDisplayed(KraftUsersGuideIcon, "KraftUsersGuideIcon");
            bool assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            ClickElement(KraftUsersGuideIcon);
            Assert.That(KraftUsersGuidePage_Assert.Text == "Kraft CRM Users guide", "Kraft Users guide page error");
        }

        public void Logout()
        {
            // Open user option menu
            string[] assertTopElements = Element_Extensions.IsDisplayed(UserOption_Menu, "UserOption_Menu");
            bool assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            ClickElement(UserOption_Menu);
            // Click Logout button
            Assert.That(Logout_Button.Text == "Logout", "Logout button is not working");
            ClickElement(Logout_Button);
            Assert.That(Logout_AfterClickLogout_Assert.Text == "Log in", "Login page error, after click Logout button");
        }

        public void NotificationSettings()
        {
            ClickElement(UserOption_Menu);
            Assert.That(NotificationSettings_Button.Text == "Notification settings", "Notification settings button is not working");
            ClickElement(NotificationSettings_Button);

            Assert.That(NotificationSettings_SubscribeForApplicationText.Text == "Subscribe for Applications:", " 'Subscribe for Applications:' is not displayed");
            Assert.That(NotificationSettings_BoardText.Text == "Board", " 'Board' is not displayed");
            Assert.That(NotificationSettings_CrmText.Text == "CRM", " 'CRM' is not displayed");
            Assert.That(NotificationSettings_ReceiveNotificationsThroughText.Text == "Receive notifications through:", " 'Receive notifications through: ' is not displayed");
            Assert.That(NotificationSettings_DesktopText.Text == "Desktop", " 'Desktop' is not displayed");
            Assert.That(NotificationSettings_InAppText.Text == "In-App", " 'In-App' is not displayed");

            Assert.That(NotificationSettings_WindowAssert.Text == "Notification Settings", "Notification settings window is not working");
            Assert.That(NotificationSettings_BoardCheckBox.Displayed);
            ClickElement(NotificationSettings_BoardCheckBox);
            Assert.That(NotificationSettings_CrmCheckBox.Displayed);
            ClickElement(NotificationSettings_CrmCheckBox);
            Assert.That(NotificationSettings_DecktopCheckBox.Displayed);
            ClickElement(NotificationSettings_DecktopCheckBox);
            Assert.That(NotificationSettings_InAppCheckBox.Displayed);
            ClickElement(NotificationSettings_InAppCheckBox);
            Assert.That(NotificationSettings_SaveButton.Text == "Save", "Save button is not displayed");
            ClickElement(NotificationSettings_SaveButton);
            Assert.That(KraftCrm.Text == "KraftCRM", "Save button is not working");
        }
    }
}
