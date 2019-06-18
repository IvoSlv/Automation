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

        [FindsBy(How = How.XPath, Using = "//div[@class='bk-tabs-panel bk-window-header-height flex-justify']//button[1]")]
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

        [FindsBy(How = How.XPath, Using = "//section[@class='bk-overview-look']//span[2]")]
        [CacheLookup]
        public IWebElement Company_AddImage { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class='bk-svg-avatar']//*[@id='Layer_1']")]
        [CacheLookup]
        public IWebElement Company_DefaultImage { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Enter the name of the company']")]
        [CacheLookup]
        public IWebElement Company_NameField { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Enter the abbreviatin of the company']")]
        [CacheLookup]
        public IWebElement Company_abbreviatinField { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Enter key words, characters, numbers']")]
        [CacheLookup]
        public IWebElement Company_TagField { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Save')]")]
        [CacheLookup]
        public IWebElement Company_SaveButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@id='delete']")]
        [CacheLookup]
        public IWebElement Company_DeleteButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@class='bk-pager-container']")]
        [CacheLookup]
        public IWebElement Company_DeleteCompanyAssert { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Yes')]")]
        [CacheLookup]
        public IWebElement Company_DeleteButtonYes { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'No')]")]
        [CacheLookup]
        public IWebElement Company_DeleteButtonNo { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Company')]")]
        [CacheLookup]
        public IWebElement Company_CompanyMenu { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Addresses')]")]
        [CacheLookup]
        public IWebElement Company_AddessesMenu { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Contacts')]")]
        [CacheLookup]
        public IWebElement Company_ContactsMenu { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'People')]")]
        [CacheLookup]
        public IWebElement Company_PeopleMenu { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Comments (0)')]")]
        [CacheLookup]
        public IWebElement Company_CommentsMenu { get; set; }
        #endregion

        public void CheckMainTabsAndOptions()
        {
            //Open CRM
            string[] assertTopElements = Element_Extensions.IsDisplayed(OpenCrm, "Ivo CRM is not displayed");
            bool assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            ClickElement(OpenCrm);
            //Check Companies,People,Reminders,Users tabs
            Task.Delay(500).Wait();
            Assert.That(CompanyTab.Text == "Companies", "Companies tab is not displayed");
            Assert.That(PeopleTab.Text == "People", "People tab is not displayed");
            Assert.That(RemindersTab.Text == "Reminders", "Reminders tab is not displayed");
            Assert.That(UsersTab.Text == "Users", "Users tab is not displayed");
            //Search field
            assertTopElements = Element_Extensions.IsDisplayed(SearchField, "Search Field is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            //Import icon
            assertTopElements = Element_Extensions.IsDisplayed(ImportIcon, "Import Icon is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            //Export icon
            assertTopElements = Element_Extensions.IsDisplayed(ExportIcon, "Export Icon is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            //Email icon
            assertTopElements = Element_Extensions.IsDisplayed(EmailIcon, "Email Icon is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            //Settings icon
            assertTopElements = Element_Extensions.IsDisplayed(SettingsIcon, "Settings Icon Icon is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            //Close icon
            assertTopElements = Element_Extensions.IsDisplayed(CloseIcon, "Close Icon Icon is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
        } 

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

        public void CheckCompanyMenus()
        {
            //Open CRM
            string[] assertTopElements = Element_Extensions.IsDisplayed(OpenCrm, "Ivo CRM is not displayed");
            bool assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            ClickElement(OpenCrm);
            //Open Company
            assertTopElements = Element_Extensions.IsDisplayed(OpenCompany, "New Company is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            ClickElement(OpenCompany);
            Task.Delay(300).Wait();
            //Check company tabs 
            Assert.That(Company_CompanyMenu.Text == "Company", "Company menu is not displayed");
            Assert.That(Company_AddessesMenu.Text == "Addresses", "Addresses menu is not displayed");
            Assert.That(Company_ContactsMenu.Text == "Contacts", "Contacts menu is not displayed");
            Assert.That(Company_PeopleMenu.Text == "People", "People menu is not displayed");
            Assert.That(Company_CommentsMenu.Text == "Comments (0)", "Comments menu is not displayed");
        }

        public void CompanyMenu()
        {
            ClickElement(OpenCrm);
            //Open company
            string[] assertTopElements = Element_Extensions.IsDisplayed(OpenCompany, "New Company is not displayed");
            bool assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            ClickElement(OpenCompany);
            //Check default image
            assertTopElements = Element_Extensions.IsDisplayed(Company_DefaultImage, "Default Image is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            //Check add image button
            assertTopElements = Element_Extensions.IsDisplayed(Company_AddImage, "Add Image button is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            //Name field
            assertTopElements = Element_Extensions.IsDisplayed(CreateCompany_NameField, "Name field is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            //Abbreviation field
            assertTopElements = Element_Extensions.IsDisplayed(CreateCompany_AbbreviationField, "Abbreviation field is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            //Industry field
            assertTopElements = Element_Extensions.IsDisplayed(CreateCompany_IndustryField, "Industry field is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            CreateCompany_IndustryField.EnterText("New Trade");
            //CEO field
            assertTopElements = Element_Extensions.IsDisplayed(CreateCompany_CeoField, "Ceo field is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            //Tags field
            assertTopElements = Element_Extensions.IsDisplayed(Company_TagField, "Tags field is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            //Save button
            assertTopElements = Element_Extensions.IsDisplayed(Company_SaveButton, "Save button is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            //Delete button
            assertTopElements = Element_Extensions.IsDisplayed(Company_DeleteButton, "Delete button is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            ClickElement(Company_DeleteButton);
            //Delete button (Yes)
            assertTopElements = Element_Extensions.IsDisplayed(Company_DeleteButtonYes, "Delete button (Yes) is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            //Delete button (No)
            assertTopElements = Element_Extensions.IsDisplayed(Company_DeleteButtonNo, "Delete button (No) is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            ClickElement(Company_DeleteButtonNo);
        }

    }
}
