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

        [FindsBy(How = How.XPath, Using = "//div[@class='bk-activity']//div//h3[@class='bk-fsize-large'][contains(text(),'Boards')]")]
        [CacheLookup]
        public IWebElement KraftBoard_Assert { get; set; }

        [FindsBy(How = How.XPath, Using = "//p[@class='bk-font-strong bk-fsize-normal bk-margin-normal'][contains(text(),'KraftHRM')]")]
        [CacheLookup]
        public IWebElement KraftHrm { get; set; }
        #endregion

        public void GoToCrm()
        {
            ClickElement(KraftCrm);
            Assert.AreEqual(KraftCrm, KraftCrm);
            driver.Navigate().Back();
        }
        public void GoToBoard()
        {
            ClickElement(KraftBoard);
            Assert.AreEqual(KraftBoard, KraftBoard);
        }
    }
}
