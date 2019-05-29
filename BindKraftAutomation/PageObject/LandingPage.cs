﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Linq;
using NUnit.Framework;
using System;
using OpenQA.Selenium.Support.UI;
using BindKraftAutomation.Models;
using BindKraftAutomation.Globals;

namespace BindKraftAutomation.PageObject
{
    sealed class LandingPage : PageTestBase
    {
        private readonly WebDriverWait wait;
        private const int BOOL_INDEX = 0;
        private const int ERR_MSG_INDEX = 1;

        #region
        [FindsBy(How = How.XPath, Using = "//i[@class='material-icons close']")]
        [CacheLookup]
        public IWebElement Features_Close { get; set; }

        [FindsBy(How = How.XPath, Using = "//i[@class='material-icons close']")]
        [CacheLookup]
        public IWebElement KraftCrm_Close { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Privacy Policy')]")]
        [CacheLookup]
        public IWebElement PrivacyPollicy { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Terms of Use')]")]
        [CacheLookup]
        public IWebElement TermsOfUse { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='user-friendly']//div[@class='ka-bind-txt']")]
        [CacheLookup]
        public IWebElement Features_Visionary { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='accurate-and-rapid']//div[@class='ka-bind-txt']")]
        [CacheLookup]
        public IWebElement Features_AccurateRapid { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='awesome-ui-and-ux']//div[@class='ka-bind-txt']")]
        [CacheLookup]
        public IWebElement Features_AwesomeUI { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='no-limits']//div[@class='ka-bind-txt']")]
        [CacheLookup]
        public IWebElement Features_NoLimits { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='CRM-Basic-Plan']//div//a[contains(text(),'Get Started')]")]
        [CacheLookup]
        public IWebElement KraftCrmPlans_BasicPlan_GetStarted { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='CRM-Basic-Plan']//div//a[@class='ka-app-planitem-modalbutton article'][contains(text(),'see all...')]")]
        [CacheLookup]
        public IWebElement KraftCrmPlans_BasicPlan_SeeAll { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='play-demo-crm']//div[@class='ka-app-feature-content']")]
        [CacheLookup]
        public IWebElement KraftCrm_PlayDemo { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='customized-features']//div[@class='ka-app-feature-content']")]
        [CacheLookup]
        public IWebElement KraftCrm_CustomizedFeatures { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='company-and-individual-cards']//div[@class='ka-app-feature-content']")]
        [CacheLookup]
        public IWebElement KraftCrm_CompanyAndIndividualCards { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Assigning many different tasks and calls to your c')]")]
        [CacheLookup]
        public IWebElement KraftCrm_PrivateAndSharedCrm { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='Board-Basic-Plan-free']//div//a[contains(text(),'Get Started')]")]
        [CacheLookup]
        public IWebElement KraftBoardPlans_GetStarted { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='Board-Basic-Plan-free']//div//a[@class='ka-app-planitem-modalbutton article'][contains(text(),'see all...')]")]
        [CacheLookup]
        public IWebElement KraftBoardPlansBasicPlan_SeeAll { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='play-demo-boads']//div[@class='ka-app-feature-content']")]
        [CacheLookup]
        public IWebElement KraftBoard_PlayDemo{ get; set; }

        [FindsBy(How =How.XPath, Using = "//span[contains(text(),'Boards')]")]
        [CacheLookup]
        public IWebElement KraftBoard_Boards { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Teams')]")]
        [CacheLookup]
        public IWebElement KraftBoard_Teams { get; set; }

        [FindsBy(How = How.XPath, Using = "//i[@class='material-icons close']")]
        [CacheLookup]
        public IWebElement KraftMenuClose { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='diversified-access-rights']//div[@class='ka-app-feature-content']")]
        [CacheLookup]
        public IWebElement KraftBoard_DiversifiedAccessRight { get; set; }

        [FindsBy(How =How.XPath, Using = "//div[@class='nav-container']//a[contains(text(),'Home')]")]
        [CacheLookup]
        public IWebElement Home { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='nav-container']//a[contains(text(),'Features')]")]
        [CacheLookup]
        public IWebElement Features { get; set; }

        [FindsBy(How =How.XPath, Using = "//div[@class='nav-container']//a[contains(text(),'KraftCRM plans')]")]
        [CacheLookup]
        public IWebElement KraftCrmPlans { get; set; }

        [FindsBy(How =How.XPath, Using = "//div[@class='nav-container']//a[contains(text(),'KraftBoard plans')]")]
        [CacheLookup]
        public IWebElement KraftBoardPlans { get; set; }

        [FindsBy(How = How.XPath, Using = "//li[4]//a[1]")]
        [CacheLookup]
        public IWebElement KraftCrm { get; set; }

        [FindsBy(How = How.XPath, Using = "//li[2]//a[1]")]
        [CacheLookup]
        public IWebElement KraftBoard { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='ka-btn-start is-active']//a[contains(text(),'Get Started')]")]
        [CacheLookup]
        public IWebElement GetStarted { get; set; }


        [FindsBy(How = How.XPath, Using = "//div[4]//a[1]//img[1]")]
        [CacheLookup]
        public IWebElement Certificate_Iso27001 { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[5]//a[1]//img[1]")]
        [CacheLookup]
        public IWebElement Certificate_Iso9001 { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='modal-body']//iframe")]
        [CacheLookup]
        public IWebElement PlayDemo_Assert { get; set; }

        [FindsBy(How = How.XPath, Using = "//h4[@id='modal-title']")]
        [CacheLookup]
        public IWebElement BoardsPopTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='modal-body']//div[contains(text(),'Easily create your boards and share them with your')]")]
        [CacheLookup]
        public IWebElement BoardsPopContent { get; set; }
        
        #endregion

        public LandingPage(IWebDriver driver)
        {
            this.driver = driver;
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            this.wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(10000));
            PageFactory.InitElements(driver, this);
        }
        
        //Sample - used in KraftBoardMenu()
        public bool testBoardPopUp()
        {
            var len = BoardsPopContent.Text.Length;
            var textStart = BoardsPopContent.Text.Trim().Substring(0, 6);
            var textEnd = BoardsPopContent.Text.Substring(len - 6);

            if (BoardsPopTitle.Text != "Boards" ||
                textStart != "Easily" ||
                textEnd != "teams.")
            {
                return false;
            }

            return true;
        }
        
        public void KraftBoardMenu()
        {
            string[] assertTopElements = Helpers.assertByStartHtml(BoardsPopContent.Text, "Easily", 6);
            bool assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;

            Assert.That(KraftBoard.Text == "KraftBoard");
            ClickElement(KraftBoard_Boards);
            Assert.That(testBoardPopUp(), "Kraft board pop up error.");
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            ClickElement(KraftMenuClose);

            ClickElement(KraftBoard_Teams);
            //TODO: Assert the text in the pop up
            ClickElement(KraftMenuClose);

            ClickElement(KraftBoard_DiversifiedAccessRight);
            //TODO: Assert the text in the pop up
            ClickElement(KraftMenuClose);

            //Think of something to assert video is playing
            ClickElement(KraftBoard_PlayDemo, KraftMenuClose);
            Assert.AreEqual(PlayDemo_Assert, PlayDemo_Assert);
        }

        public void KraftBoardPlansMenu()
        {
            ClickElement(KraftBoardPlans);
            Assert.AreEqual(KraftBoardPlans, KraftBoardPlans);
            ClickElement(KraftBoardPlansBasicPlan_SeeAll, KraftMenuClose);
            Assert.AreEqual(KraftBoardPlansBasicPlan_SeeAll, KraftBoardPlansBasicPlan_SeeAll);
            ClickElement(KraftBoardPlans_GetStarted);
            Assert.AreEqual(KraftBoardPlans_GetStarted, KraftBoardPlans_GetStarted);
            driver.Navigate().Back();
        }

        public void KraftCrmMenu()
        {
            ClickElement(KraftCrm);
            Assert.AreEqual(KraftCrm, KraftCrm);
            ClickElement(KraftCrm_PrivateAndSharedCrm, KraftMenuClose);
            Assert.AreEqual(KraftCrm_PrivateAndSharedCrm, KraftCrm_PrivateAndSharedCrm);
            ClickElement(KraftCrm_CompanyAndIndividualCards, KraftMenuClose);
            Assert.AreEqual(KraftCrm_CompanyAndIndividualCards, KraftCrm_CompanyAndIndividualCards);
            ClickElement(KraftCrm_CustomizedFeatures, KraftMenuClose);
            Assert.AreEqual(KraftCrm_CustomizedFeatures, KraftCrm_CustomizedFeatures);
            ClickElement(KraftCrm_PlayDemo, KraftMenuClose);
            Assert.AreEqual(KraftCrm_PlayDemo, KraftCrm_PlayDemo);
            Assert.AreEqual(PlayDemo_Assert, PlayDemo_Assert);
        }

        public void KraftCrmPlansMenu()
        {
            ClickElement(KraftCrmPlans);
            Assert.AreEqual(KraftCrmPlans, KraftCrmPlans);
            ClickElement(KraftCrmPlans_BasicPlan_SeeAll, KraftCrm_Close);
            Assert.AreEqual(KraftCrmPlans_BasicPlan_SeeAll, KraftCrmPlans_BasicPlan_SeeAll);
            ClickElement(KraftCrmPlans_BasicPlan_GetStarted);
            Assert.AreEqual(KraftCrmPlans_BasicPlan_GetStarted, KraftCrmPlans_BasicPlan_GetStarted);
            driver.Navigate().Back();
        }

        public void FeaturesMenu()
        {
            ClickElement(Features);
            Assert.AreEqual(Features, Features);
            ClickElement(Features_NoLimits, Features_Close);
            Assert.AreEqual(Features_NoLimits, Features_NoLimits);
            ClickElement(Features_Visionary, Features_Close);
            Assert.AreEqual(Features_Visionary, Features_Visionary);
            ClickElement(Features_AccurateRapid, Features_Close);
            Assert.AreEqual(Features_AccurateRapid, Features_AccurateRapid);
            ClickElement(Features_AwesomeUI, Features_Close);
            Assert.AreEqual(Features_AwesomeUI, Features_AwesomeUI);
        }

        public void HomeMenu()
        {
            ClickElement(Home);
            Assert.AreEqual(Home, Home);
        }

        public void GoToLoginPage()
        {
            ClickElement(GetStarted);
            Assert.AreEqual(GetStarted, GetStarted);
        }

        public void TermsOfUse_PrivacyPollicy()
        {
            ClickElement(TermsOfUse);
            Assert.AreEqual(TermsOfUse, TermsOfUse);
            driver.Navigate().Back();
            ClickElement(PrivacyPollicy);
            Assert.AreEqual(PrivacyPollicy, PrivacyPollicy);
            driver.Navigate().Back();
        }

        public void Certificate1()
        {
            Certificate_Iso27001.Click();

            string newTabHandle = driver.WindowHandles.Last();
            var newTab = driver.SwitchTo().Window(newTabHandle);

            var expectedNewTabTitle = "CN-17405IIS-EN.jpg (584×830)";
            Assert.AreEqual(expectedNewTabTitle, newTab.Title);
        }

        public void Certificate2()
        {
            Certificate_Iso9001.Click();

            string newTabHandle = driver.WindowHandles.Last();
            var newTab = driver.SwitchTo().Window(newTabHandle);

            var expectedNewTabTitle = "ISO-CN-17405IQ-EN.jpg (584×830)";
            Assert.AreEqual(expectedNewTabTitle, newTab.Title);
        }
    }
}
