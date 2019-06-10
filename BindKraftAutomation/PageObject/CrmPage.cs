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
        public IWebElement OpenCrm { get; set; }

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

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Enter the abbreviatin of the company']")]
        [CacheLookup]
        public IWebElement CreateCompany_AbbreviationField { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Enter the type of industry. E.g Trade, Food, Electronic']")]
        [CacheLookup]
        public IWebElement CreateCompany_IndustryField { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Enter the name of the CEO']")]
        [CacheLookup]
        public IWebElement CreateCompany_CeoField { get; set; }

        [FindsBy(How = How.XPath, Using = "//body//div[@class='bk-companies-list bk-flex']//div//div[1]//div[4]//span[1]")]
        [CacheLookup]
        public IWebElement OpenCompany { get; set; }
        #endregion

        public void CreateCompany()
        {
            //Open CRM 
            string[] assertTopElements = Element_Extensions.IsDisplayed(OpenCrm, "Ivo CRM is not displayed");
            bool assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            ClickElement(OpenCrm);
            //Click on Create company button
            Assert.That(CreateCompany_PlusButton.Text == "+", "CreateCompany_PlusButton is not working");
            ClickElement(CreateCompany_PlusButton);
            //Enter text on name field 
            assertTopElements = Element_Extensions.IsDisplayed(CreateCompany_NameField, "CreateCompany_NameField");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            CreateCompany_NameField.EnterText("New Company");
            //Enter text on abbreviation field 
            assertTopElements = Element_Extensions.IsDisplayed(CreateCompany_AbbreviationField, "CreateCompany_AbbreviationField is not working");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            CreateCompany_AbbreviationField.EnterText("New Abb");
            //Enter text on industry field 
            assertTopElements = Element_Extensions.IsDisplayed(CreateCompany_IndustryField, "CreateCompany_IndustryField is not working");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            CreateCompany_IndustryField.EnterText("Trade");
            //Enter text on CEO field 
            assertTopElements = Element_Extensions.IsDisplayed(CreateCompany_CeoField, "CreateCompany_CeoField is not working");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            CreateCompany_CeoField.EnterText("John");
            //Click on save button
            assertTopElements = Element_Extensions.IsDisplayed(CreateCompany_SaveButton, "CreateCompany_SaveButton is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            ClickElement(CreateCompany_SaveButton);
        }

        public void CheckCompanyContent()
        {
            ClickElement(OpenCrm);
            string[] assertTopElements = Element_Extensions.IsDisplayed(OpenCompany, "New Company is not displayed");
            bool assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            ClickElement(OpenCompany);
        }

    }
}
