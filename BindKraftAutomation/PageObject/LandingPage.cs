using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading.Tasks;
using BindKraftAutomation.Extensions;
using System.Linq;
using NUnit.Framework;
using System;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

namespace BindKraftAutomation.PageObject
{
    sealed class LandingPage
    {
        private IWebDriver driver;
        private readonly WebDriverWait wait; 

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

        [FindsBy(How = How.XPath, Using = "//div[@class='ellipsis'][contains(text(),'Best practices are to assign task to few projects ')]")]
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

        [FindsBy(How =How.XPath, Using = "//div[@class='nav-container']//a[contains(text(),'Kraft CRM plans')]")]
        [CacheLookup]
        public IWebElement KraftCrmPlans { get; set; }

        [FindsBy(How =How.XPath, Using = "//div[@class='nav-container']//a[contains(text(),'Kraft Board plans')]")]
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
        #endregion

        public LandingPage(IWebDriver driver)
        {
            this.driver = driver;
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            this.wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(10000));
            PageFactory.InitElements(driver, this);
        }

        public void WindowMaximize()
        {
            driver.Manage().Window.Maximize();
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

        public void KraftBoardMenu()
        {
            ClickElement(KraftBoard);
            ClickElement(KraftBoard_Boards, KraftMenuClose);
            ClickElement(KraftBoard_Teams, KraftMenuClose);
            ClickElement(KraftBoard_DiversifiedAccessRight, KraftMenuClose);
            ClickElement(KraftBoard_PlayDemo, KraftMenuClose);
        }

        public void KraftBoardPlansMenu()
        {
            ClickElement(KraftBoardPlans);
            ClickElement(KraftBoardPlansBasicPlan_SeeAll, KraftMenuClose);
            ClickElement(KraftBoardPlans_GetStarted);
            ClickElement(KraftBoard);
            driver.Navigate().Back();
        }

        public void KraftCrmMenu()
        {
            ClickElement(KraftCrm);
            ClickElement(KraftCrm_PrivateAndSharedCrm, KraftMenuClose);
            ClickElement(KraftCrm_CompanyAndIndividualCards, KraftMenuClose);
            ClickElement(KraftCrm_CustomizedFeatures, KraftMenuClose);
            ClickElement(KraftCrm_PlayDemo, KraftMenuClose);
        }

        public void KraftCrmPlansMenu()
        {
            ClickElement(KraftCrmPlans);
            ClickElement(KraftCrmPlans_BasicPlan_SeeAll, KraftCrm_Close);
            ClickElement(KraftCrmPlans_BasicPlan_GetStarted);
            driver.Navigate().Back();
        }

        public void FeaturesMenu()
        {
            ClickElement(Features);
            ClickElement(Features_NoLimits, Features_Close);
            ClickElement(Features_Visionary, Features_Close);
            ClickElement(Features_AccurateRapid, Features_Close);
            ClickElement(Features_AwesomeUI, Features_Close);
        }

        public void HomeMenu()
        {
            ClickElement(Home);
        }

        public void GoToLoginPage()
        {
            //TODO: Optimize this for consistency
            Task.Delay(2000).Wait();
            GetStarted.ClickOnIt("GetStarted");
        }

        public void TermsOfUse_PrivacyPollicy()
        {
            ClickElement(TermsOfUse);
            driver.Navigate().Back();
            ClickElement(PrivacyPollicy);
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
