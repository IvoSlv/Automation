using OpenQA.Selenium;
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

        [FindsBy(How = How.XPath, Using = "//em[@class='material-icons welcome-close']")]
        [CacheLookup]
        public IWebElement WelcomePopup_Close { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='ka-btn-start ka-btn-modal is-active']//a//img")]
        [CacheLookup]
        public IWebElement WelcomePopup_GetStarted { get; set; }

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

        [FindsBy(How = How.XPath, Using = "//a[@id='play-demo-boads']//span[@class='ka-feature-heading'][contains(text(),'Play Demo')]")]
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

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Diversified Access Rights')]")]
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

        [FindsBy(How = How.XPath, Using = "//div[@class='ka-btn-start is-active']//a//img")]
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

        [FindsBy(How = How.XPath, Using = "//div[@id='myModal']//p[1]")]
        [CacheLookup]
        public IWebElement BoardsPopContent { get; set; }

        [FindsBy(How = How.XPath, Using = "//h2[@class='bk-login-title']")]
        [CacheLookup]
        public IWebElement LogInPage_LogInTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='modal-body']//div[contains(text(),'The best practices are to assign tasks to few proj')]")]
        [CacheLookup]
        public IWebElement TeamsPopContent { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='modal-body']//iframe")]
        [CacheLookup]
        public IWebElement KraftBoard_PlayDemoPopContent { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='modal-body']")]
        [CacheLookup]
        public IWebElement KraftBoard_DiversifiedAccessRightPopContent { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='ka-document']")]
        [CacheLookup]
        public IWebElement TermsOfService_AssertContent { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='ka-document']")]
        [CacheLookup]
        public IWebElement PrivacyPolicy_AssertContent { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='modal-body']//div//li[contains(text(),'Unlimited number of Boards')]")]
        [CacheLookup]
        public IWebElement KraftBoardPlansBasicPlan_SeeAllContent { get; set; }

        #endregion

        public LandingPage(IWebDriver driver)
        {
            this.driver = driver;
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            this.wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(10000));
            PageFactory.InitElements(driver, this);
        }
          
        
        public void KraftBoardMenu()
        {
            
            //Boards
            Assert.That(KraftBoard_Boards.Text == "Boards", "Boards pop up error");
            ClickElement(KraftBoard_Boards);
            string[] assertTopElements = Helpers.assertByStartHtml(BoardsPopContent.Text, "Easily", 6);
            bool assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            assertTopElements = Helpers.IsDisplayed(KraftMenuClose, "KraftMenuClose");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            ClickElement(KraftMenuClose);
            //Teams
            Assert.That(KraftBoard_Teams.Text == "Teams", "Teams pop up error");
            ClickElement(KraftBoard_Teams);
            assertTopElements = Helpers.assertByStartHtml(TeamsPopContent.Text, "The best", 8);
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            assertTopElements = Helpers.IsDisplayed(KraftMenuClose, "KraftMenuClose");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            ClickElement(KraftMenuClose);
            //Diversified Access Right
            Assert.That(KraftBoard_DiversifiedAccessRight.Text == "Diversified Access Rights", "Diversified Access Rights pop up error");
            ClickElement(KraftBoard_DiversifiedAccessRight);
            assertTopElements = Helpers.assertByStartHtml(KraftBoard_DiversifiedAccessRightPopContent.Text, "The ability", 11);
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            assertTopElements = Helpers.IsDisplayed(KraftMenuClose, "KraftMenuClose");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            ClickElement(KraftMenuClose);
            //Play demo
            Assert.That(KraftBoard_PlayDemo.Text == "Play Demo", "Play Demo pop up error");
            ClickElement(KraftBoard_PlayDemo);
            Assert.That(KraftBoard_PlayDemoPopContent.Displayed);
            assertTopElements = Helpers.IsDisplayed(KraftMenuClose, "KraftMenuClose");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            ClickElement(KraftMenuClose);
            
        }
        
        public void KraftBoardPlansMenu()
        {
            Assert.That(KraftBoardPlansBasicPlan_SeeAll.Text == "see all...", "See all pop up is not displayed");
            ClickElement(KraftBoardPlansBasicPlan_SeeAll);
            Assert.That(KraftBoardPlansBasicPlan_SeeAllContent.Text == "Unlimited number of Boards", "See all pop up error");

            string [] assertTopElements = Helpers.IsDisplayed(KraftMenuClose, "KraftMenuClose");
            bool assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            ClickElement(KraftMenuClose);

            Assert.That(KraftBoardPlans_GetStarted.Text == "Get Started", "Get started button is not displayed");
            ClickElement(KraftBoardPlans_GetStarted);
            Assert.That(LogInPage_LogInTitle.Text == "Log in", "Log in title is missing");
        }
        //TODO: Under construction
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
        //TODO: Under construction
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
        //TODO: Under construction
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
        
        public void GoToLoginPage()
        {
            ClickElement(WelcomePopup_Close);
            //Assert.That(GetStarted.Text == "Get Started","Get Started button error");
            ClickElement(GetStarted);
            //Assert.That(LogInPage_LogInTitle.Text == "Log in","Log in title is missing");
        }

        public void TermsOfUse_PrivacyPollicy()
        {
            //Terms of Use
            Assert.That(TermsOfUse.Text == "Terms of Use", "Terms of Use link is not work");
            ClickElement(TermsOfUse);

            //Assert content
            string[] assertTopElements = Helpers.assertByStartHtml(TermsOfService_AssertContent.Text, "TERMS", 5);
            bool assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            driver.Navigate().Back();

            //Privacy Policy
            Assert.That(PrivacyPollicy.Text == "Privacy Policy", "Privacy Policy link is not work");
            ClickElement(PrivacyPollicy);

            //Assert content
            assertTopElements = Helpers.assertByStartHtml(PrivacyPolicy_AssertContent.Text, "Privacy", 7);
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            driver.Navigate().Back();
        }

        public void Certificate1()
        {
            string[] assertTopElements = Helpers.IsDisplayed(Certificate_Iso27001, "Certificate_Iso27001");
            bool assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            Certificate_Iso27001.Click();

            string newTabHandle = driver.WindowHandles.Last();
            var newTab = driver.SwitchTo().Window(newTabHandle);

            var expectedNewTabTitle = "CN-17405IIS-EN.jpg (584×830)";
            Assert.AreEqual(expectedNewTabTitle, newTab.Title, "Certificate1 - Iso27001 is not displayed");
        }

        public void Certificate2()
        {
            string[] assertTopElements = Helpers.IsDisplayed(Certificate_Iso9001, "Certificate_Iso9001");
            bool assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            Certificate_Iso9001.Click();

            string newTabHandle = driver.WindowHandles.Last();
            var newTab = driver.SwitchTo().Window(newTabHandle);

            var expectedNewTabTitle = "ISO-CN-17405IQ-EN.jpg (584×830)";
            Assert.AreEqual(expectedNewTabTitle, newTab.Title, "Certificate2 - Iso9001 is not displayed");
        }

        public void TopNavigationMenu()
        {
            Assert.That(Home.Text == "Home", "Home button error");
            Assert.That(KraftBoard.Text == "KraftBoard", "KraftBoard button error");
            Assert.That(KraftBoardPlans.Text == "KraftBoard plans", "KraftBoardPlans button error");
            Assert.That(KraftCrm.Text == "KraftCRM", "KraftCRM button error");
            Assert.That(KraftCrmPlans.Text == "KraftCRM plans", "KraftCRM plans button error");
            Assert.That(Features.Text == "Features", "Features button error");
        }
    }
}
