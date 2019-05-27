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

        [FindsBy(How = How.CssSelector, Using = "div.themed div.bk-ffamily-third div.bk-box-first:nth-child(1) div.header.f_view_container.window_active div:nth-child(1) div.bk-svg-main-oposit.hamburger-button svg:nth-child(1) g:nth-child(2) > path:nth-child(1)")]
        [CacheLookup]
        public IWebElement HomePage_Menu { get; set; }

        [FindsBy(How = How.XPath, Using = "//p[@class='bk-font-strong bk-fsize-normal bk-margin-normal'][contains(text(),'KraftHRM')]")]
        [CacheLookup]
        public IWebElement KraftHrm { get; set; }
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
        }

        public void GoToHrm()
        {
            ClickElement(KraftHrm);
            Assert.AreEqual(KraftHrm, KraftHrm);
        }

        public void OpenHomePageMenu()
        {
            ClickElement(HomePage_Menu);
        }
    }
}
