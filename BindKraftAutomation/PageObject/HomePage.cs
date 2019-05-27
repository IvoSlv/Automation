using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading.Tasks;
using BindKraftAutomation.Extensions;
using System.Linq;
using NUnit.Framework;
using System;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using BindKraftAutomation.Models;
using System.Threading;

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
        public IWebElement UserProfile_Menu { get; set; }

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/*")]
        [CacheLookup]
        public IWebElement HomePage_Menu { get; set; }

        [FindsBy(How = How.XPath, Using = "//p[@class='bk-font-strong bk-fsize-normal bk-margin-normal'][contains(text(),'KraftHRM')]")]
        [CacheLookup]
        public IWebElement KraftHrm { get; set; }

        [FindsBy(How = How.XPath, Using = "//h1[contains(text(),'Kraft Board')]")]
        [CacheLookup]
        public IWebElement KraftBoard_Assert { get; set; }
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

        public void OpenUserProfileMenu()
        {
            ClickElement(UserProfile_Menu);
            Assert.AreEqual(UserProfile_Menu, UserProfile_Menu);

        }
    }
}
