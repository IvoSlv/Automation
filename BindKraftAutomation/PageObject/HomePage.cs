using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using NUnit.Framework;
using System;
using OpenQA.Selenium.Support.UI;
using BindKraftAutomation.Models;

namespace BindKraftAutomation.PageObject
{
    class HomePage : PageTestBase
    {
        private readonly WebDriverWait wait;

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

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/*")]
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
        #endregion

        public void GoToCrm()
        {
            ClickElement(KraftCrm);
            Assert.AreEqual(KraftCrm, KraftCrm);
        }
        public void GoToBoard()
        {
            ClickElement(KraftBoard);
            Assert.AreEqual(KraftBoard, KraftBoard);
            Assert.AreEqual(KraftBoard_Assert, KraftBoard_Assert);
        }

        public void GoToHrm()
        {
            ClickElement(KraftHrm);
            Assert.AreEqual(KraftHrm, KraftHrm);
        }

        public void OpenUserOptionMenu()
        {
            ClickElement(UserOption_Menu);
            Assert.AreEqual(UserOption_Menu, UserOption_Menu);
        }

        public void OpenUserProfile()
        {
            ClickElement(UserOption_Menu);
            ClickElement(UserProfile);
            Assert.AreEqual(UserProfile, UserProfile);
        }

        public void CheckUserProfileInfo()
        {
            ClickElement(UserOption_Menu);
            ClickElement(UserProfile);
            Assert.AreEqual(UserProfile_FirstName, UserProfile_FirstName);
            Assert.AreEqual(UserProfile_LastName, UserProfile_LastName);
            Assert.AreEqual(UserProfile_Subscribe, UserProfile_Subscribe);
            Assert.AreEqual(UserProfile_LastLoginDate, UserProfile_LastLoginDate);
        }

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

        public void OpenHamburgerMenuBotton()
        {
            ClickElement(HamburgerMenuBotton);
        }
    }
}
