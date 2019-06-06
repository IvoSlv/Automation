using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using NUnit.Framework;
using System;
using OpenQA.Selenium.Support.UI;
using BindKraftAutomation.Models;
using BindKraftAutomation.Extensions;
using System.Threading.Tasks;
using System.Diagnostics;

namespace BindKraftAutomation.PageObject
{
    class CrmPage : PageTestBase
    {
        private readonly WebDriverWait wait;
        private const int BOOL_INDEX = 0;
        private const int ERR_MSG_INDEX = 1;

        public CrmPage(IWebDriver driver)
        {
            this.driver = driver;
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            this.wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(10000));
            PageFactory.InitElements(driver, this);
        }
        #region
        [FindsBy(How = How.XPath, Using = "//div[@class='bk-board-info-box']")]
        [CacheLookup]
        public IWebElement MyCrm { get; set; }

        [FindsBy(How = How.XPath, Using = "//h4[contains(text(),'Create Company')]")]
        [CacheLookup]
        public IWebElement CreateCompany_Assert { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='bk-companies-container full-height']//div//span[@class='bk-box-create-icon'][contains(text(),'+')]")]
        [CacheLookup]
        public IWebElement CreateCompany_PlusButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Companies')]")]
        [CacheLookup]
        public IWebElement CompanyTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'People')]")]
        [CacheLookup]
        public IWebElement PeopleTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Reminders')]")]
        [CacheLookup]
        public IWebElement RemindersTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Users')]")]
        [CacheLookup]
        public IWebElement UsersTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Search ...']")]
        [CacheLookup]
        public IWebElement SearchField { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'mobile-hidden')]//*[@id='Layer_1']")]
        [CacheLookup]
        public IWebElement ImportIcon { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='bk-simplewindow window_active']//button[1]")]
        [CacheLookup]
        public IWebElement ExportIcon { get; set; }

        [FindsBy(How = How.XPath, Using = "//body//button[2]")]
        [CacheLookup]
        public IWebElement EmailIcon { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class='bk-interact bk-pushable bk-svg-main bk-margin-normal']")]
        [CacheLookup]
        public IWebElement SettingsIcon { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='bk-client-position']//span[3]")]
        [CacheLookup]
        public IWebElement CloseIcon { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Enter the name of the company']")]
        [CacheLookup]
        public IWebElement CreateCompany_NameField { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@class='bk-button bk-button-small bk-pushable']")]
        [CacheLookup]
        public IWebElement CreateCompany_SaveButton { get; set; }
        #endregion

        public void CreateCompany([Values("a", "b", "c")] string a)
        {
            ClickElement(MyCrm);
            ClickElement(CreateCompany_PlusButton);
            CreateCompany_NameField.EnterText1("{0} {1} {2}");
            ClickElement(CreateCompany_SaveButton);
        }

    }
}
