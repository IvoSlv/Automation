using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using NUnit.Framework;
using System;
using OpenQA.Selenium.Support.UI;
using BindKraftAutomation.Models;
using BindKraftAutomation.Extensions;
using System.Threading.Tasks;
using BindKraftAutomation.Globals;

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

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[2]/div[3]/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]/ul[1]/li[4]/a[1]")]
        [CacheLookup]
        public IWebElement Company_PeopleMenu { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Comments (0)')]")]
        [CacheLookup]
        public IWebElement Company_CommentsMenu { get; set; }

        [FindsBy(How = How.XPath, Using = "//h2[@class='bk-svg-main-oposit']")]
        [CacheLookup]
        public IWebElement Company_AddAddressesButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Enter the country']")]
        [CacheLookup]
        public IWebElement Company_Addresses_CountryField { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Enter the city']")]
        [CacheLookup]
        public IWebElement Company_Addresses_CityField { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Enter the street']")]
        [CacheLookup]
        public IWebElement Company_Addresses_StreetField { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Enter the additional information']")]
        [CacheLookup]
        public IWebElement Company_Addresses_AdditionalField { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@class='bk-button bk-button-small bk-interact bk-pushable bk-margin-small']")]
        [CacheLookup]
        public IWebElement Company_Addresses_SaveButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Close')]")]
        [CacheLookup]
        public IWebElement Company_Addresses_CloseButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Edit')]")]
        [CacheLookup]
        public IWebElement Company_Addresses_EditButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='bk-form-with-validation']//button[@class='bk-button bk-button-small bk-pushable'][contains(text(),'Delete')]")]
        [CacheLookup]
        public IWebElement Company_Addresses_Edit_DeleteButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@class='bk-button bk-button-small bk-pushable'][contains(text(),'Close')]")]
        [CacheLookup]
        public IWebElement Company_Addresses_Edit_CloseButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Additional...']")]
        [CacheLookup]
        public IWebElement Company_Addresses_Edit_AdditionalField { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='bk-form-with-validation']//button[@class='bk-button bk-button-small bk-pushable'][contains(text(),'Save')]")]
        [CacheLookup]
        public IWebElement Company_Addresses_Edit_SaveButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//h2[@class='bk-svg-main-oposit']")]
        [CacheLookup]
        public IWebElement Company_Contacts_AddContactButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'(please select)')]")]
        [CacheLookup]
        public IWebElement Company_Contacts_Type { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Email')]")]
        [CacheLookup]
        public IWebElement Company_Contacts_Type_Email { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Facebook')]")]
        [CacheLookup]
        public IWebElement Company_Contacts_Type_Facebook { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Phone')]")]
        [CacheLookup]
        public IWebElement Company_Contacts_Type_Phone { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'LinkedIn')]")]
        [CacheLookup]
        public IWebElement Company_Contacts_Type_LinkedIn { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Enter the contact']")]
        [CacheLookup]
        public IWebElement Company_Contacts_ImputContact { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Close')]")]
        [CacheLookup]
        public IWebElement Company_Contacts_CloseButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='bk-form-with-validation']//button[@class='bk-button bk-button-small bk-pushable'][contains(text(),'Save')]")]
        [CacheLookup]
        public IWebElement Company_Contacts_SaveButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//td[@class='bk-buckets-selected']//input[@placeholder='Search...']")]
        [CacheLookup]
        public IWebElement Company_People_bucketsSelector_Selected { get; set; }

        [FindsBy(How = How.XPath, Using = "//td[@class='bk-buckets-not-selected']//input[@placeholder='Search...']")]
        [CacheLookup]
        public IWebElement Company_People_bucketsSelector_Nonselected { get; set; }

        [FindsBy(How = How.XPath, Using = "//textarea[@placeholder='Enter your text']")]
        [CacheLookup]
        public IWebElement Company_Comments_AddComent_ImputField { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@id='addComment']")]
        [CacheLookup]
        public IWebElement Company_Comments_AddComent_Button { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='crm-tab-body']//div[3]")]
        [CacheLookup]
        public IWebElement Company_Comments_EditCommentIcon { get; set; }

        [FindsBy(How = How.XPath, Using = "//body//div[@class='bk-simplewindow-headless window_active']//div[@class='bk-simplewindow-headless window_active']//div[4]")]
        [CacheLookup]
        public IWebElement Company_Comments_DeleteCommentIcon { get; set; }

        [FindsBy(How = How.XPath, Using = "//textarea[@class='bk-edit-comment-edit-textarea']")]
        [CacheLookup]
        public IWebElement Company_Comments_EditCommentField { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='saveComment']")]
        [CacheLookup]
        public IWebElement Company_Comments_EditComment_SaveCommentIcon { get; set; }

        [FindsBy(How = How.XPath, Using = "//body//div[@class='bk-simplewindow-headless window_active']//div[@class='bk-simplewindow-headless window_active']//div[4]")]
        [CacheLookup]
        public IWebElement Company_Comments_EditComment_CloseCommentIcon { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='crm-pager']")]
        [CacheLookup]
        public IWebElement Company_Comments_DeleteComment_Assert { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='try-something']//input")]
        [CacheLookup]
        public IWebElement Settings_NameField { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@id='saveInfo']")]
        [CacheLookup]
        public IWebElement Settings_SaveButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Contact Types')]")]
        [CacheLookup]
        public IWebElement Settings_ContactTypes { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Email')]")]
        [CacheLookup]
        public IWebElement Settings_ContactTypes_Email { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Facebook')]")]
        [CacheLookup]
        public IWebElement Settings_ContactTypes_Facebook { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Phone')]")]
        [CacheLookup]
        public IWebElement Settings_ContactTypes_Phone { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'LinkedIn')]")]
        [CacheLookup]
        public IWebElement Settings_ContactTypes_LinkedIn { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'bk-tabs-panel bk-window-header-height flex-justify')]//span[contains(@class,'bk-margin-normal')]//*[@id='Layer_1']")]
        [CacheLookup]
        public IWebElement Settings_CloseIcon { get; set; }
        #endregion

        public void CheckMainTabsAndOptions()
        {
            //Open CRM
            string[] assertTopElements = Helpers.IsDisplayed(OpenCrm, "Ivo CRM is not displayed");
            bool assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            ClickElement(OpenCrm);
            //Check Companies,People,Reminders,Users tabs
            Task.Delay(1000).Wait();
            Assert.That(CompanyTab.Text == "Companies", "Companies tab is not displayed");
            Assert.That(PeopleTab.Text == "People", "People tab is not displayed");
            Assert.That(RemindersTab.Text == "Reminders", "Reminders tab is not displayed");
            Assert.That(UsersTab.Text == "Users", "Users tab is not displayed");

            //Search field
            assertTopElements = Helpers.IsDisplayed(SearchField, "Search Field is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);

            //Import icon
            assertTopElements = Helpers.IsDisplayed(ImportIcon, "Import Icon is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);

            //Export icon
            assertTopElements = Helpers.IsDisplayed(ExportIcon, "Export Icon is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);

            //Email icon
            assertTopElements = Helpers.IsDisplayed(EmailIcon, "Email Icon is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);

            //Settings icon
            assertTopElements = Helpers.IsDisplayed(SettingsIcon, "Settings Icon Icon is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);

            //Close icon
            assertTopElements = Helpers.IsDisplayed(CloseIcon, "Close Icon Icon is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
        } 

        public void CreateCompany()
        {
            //Open CRM 
            string[] assertTopElements = Helpers.IsDisplayed(OpenCrm, "Ivo CRM is not displayed");
            bool assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            ClickElement(OpenCrm);

            //Click on Create company button
            Assert.That(CreateCompany_PlusButton.Text == "+", "CreateCompany_PlusButton is not working");
            ClickElement(CreateCompany_PlusButton);

            //Enter text on name field 
            assertTopElements = Helpers.IsDisplayed(CreateCompany_NameField, "CreateCompany_NameField");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            CreateCompany_NameField.EnterText("New Company");

            //Enter text on abbreviation field 
            assertTopElements = Helpers.IsDisplayed(CreateCompany_AbbreviationField, "CreateCompany_AbbreviationField is not working");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            CreateCompany_AbbreviationField.EnterText("New Abb");

            //Enter text on industry field 
            assertTopElements = Helpers.IsDisplayed(CreateCompany_IndustryField, "CreateCompany_IndustryField is not working");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            CreateCompany_IndustryField.EnterText("Trade");

            //Enter text on CEO field 
            assertTopElements = Helpers.IsDisplayed(CreateCompany_CeoField, "CreateCompany_CeoField is not working");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            CreateCompany_CeoField.EnterText("John");

            //Click on save button
            assertTopElements = Helpers.IsDisplayed(CreateCompany_SaveButton, "CreateCompany_SaveButton is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            ClickElement(CreateCompany_SaveButton);
        }

        public void CheckCompanyMenus()
        {
            //Open CRM
            string[] assertTopElements = Helpers.IsDisplayed(OpenCrm, "Ivo CRM is not displayed");
            bool assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            ClickElement(OpenCrm);
            //Open Company
            assertTopElements = Helpers.IsDisplayed(OpenCompany, "New Company is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            ClickElement(OpenCompany);
            //Task.Delay(300).Wait();

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
            string[] assertTopElements = Helpers.IsDisplayed(OpenCompany, "New Company is not displayed");
            bool assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            ClickElement(OpenCompany);

            //Check default image
            assertTopElements = Helpers.IsDisplayed(Company_DefaultImage, "Default Image is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);

            //Check add image button
            assertTopElements = Helpers.IsDisplayed(Company_AddImage, "Add Image button is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);

            //Name field
            assertTopElements = Helpers.IsDisplayed(CreateCompany_NameField, "Name field is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);

            //Abbreviation field
            assertTopElements = Helpers.IsDisplayed(CreateCompany_AbbreviationField, "Abbreviation field is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);

            //Industry field
            assertTopElements = Helpers.IsDisplayed(CreateCompany_IndustryField, "Industry field is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            CreateCompany_IndustryField.EnterText("New Trade");

            //CEO field
            assertTopElements = Helpers.IsDisplayed(CreateCompany_CeoField, "Ceo field is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);

            //Tags field
            assertTopElements = Helpers.IsDisplayed(Company_TagField, "Tags field is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);

            //Save button
            assertTopElements = Helpers.IsDisplayed(Company_SaveButton, "Save button is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);

            //Delete button
            assertTopElements = Helpers.IsDisplayed(Company_DeleteButton, "Delete button is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            ClickElement(Company_DeleteButton);

            //Delete button (Yes)
            assertTopElements = Helpers.IsDisplayed(Company_DeleteButtonYes, "Delete button (Yes) is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);

            //Delete button (No)
            assertTopElements = Helpers.IsDisplayed(Company_DeleteButtonNo, "Delete button (No) is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            ClickElement(Company_DeleteButtonNo);
        }

        public void CompanyAddressesMenu()
        {
            //Open CRM
            string[] assertTopElements = Helpers.IsDisplayed(OpenCrm, "Ivo CRM is not displayed");
            bool assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            ClickElement(OpenCrm);

            //Open Company
            assertTopElements = Helpers.IsDisplayed(OpenCompany, "New Company is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            ClickElement(OpenCompany);
            Task.Delay(300).Wait();

            //Addresses tab
            Assert.That(Company_AddessesMenu.Text == "Addresses", "Addresses menu is not displayed");
            ClickElement(Company_AddessesMenu);

            //Add adresses button
            assertTopElements = Helpers.IsDisplayed(Company_AddAddressesButton, "Add Addresses button is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            ClickElement(Company_AddAddressesButton);

            //Country field
            assertTopElements = Helpers.IsDisplayed(Company_Addresses_CountryField, "Addresses - Country Field is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            Company_Addresses_CountryField.EnterText("Bulgaria");

            //City field
            assertTopElements = Helpers.IsDisplayed(Company_Addresses_CityField, "Addresses_City Field is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            Company_Addresses_CityField.EnterText("Sofia");

            //Street field
            assertTopElements = Helpers.IsDisplayed(Company_Addresses_StreetField, "Addresses_Street Field is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            Company_Addresses_StreetField.EnterText("Friend 12");

            //Additional field
            assertTopElements = Helpers.IsDisplayed(Company_Addresses_AdditionalField, "Addresses_Additional Field is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            Company_Addresses_AdditionalField.EnterText("DSA");

            //Close button
            Assert.That(Company_Addresses_CloseButton.Text == "Close", "Close button is not displayed");

            //Save button
            assertTopElements = Helpers.IsDisplayed(Company_Addresses_SaveButton, "Save button is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            ClickElement(Company_Addresses_SaveButton);

            //Edit button
            Assert.That(Company_Addresses_EditButton.Text == "Edit", "Save button is not working");
            assertTopElements = Helpers.IsDisplayed(Company_Addresses_EditButton, "New Company is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            ClickElement(Company_Addresses_EditButton);

            //Close button
            assertTopElements = Helpers.IsDisplayed(Company_Addresses_Edit_CloseButton, "New Company is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);

            //Additional field
            assertTopElements = Helpers.IsDisplayed(Company_Addresses_Edit_AdditionalField, "New Company is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            Company_Addresses_Edit_AdditionalField.EnterText("DSA");

            //Save button
            assertTopElements = Helpers.IsDisplayed(Company_Addresses_Edit_SaveButton, "New Company is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);

            //Delete button
            assertTopElements = Helpers.IsDisplayed(Company_Addresses_Edit_DeleteButton, "New Company is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            ClickElement(Company_Addresses_Edit_DeleteButton);

            //Delete button Yes/No
            Assert.That(Company_DeleteButtonNo.Text == "No", "Addresses menu is not displayed");
            Assert.That(Company_DeleteButtonYes.Text == "Yes", "Addresses menu is not displayed");
            ClickElement(Company_DeleteButtonYes);
        }

        public void CompanyContactsMenu()
        {
            //Open CRM
            string[] assertTopElements = Helpers.IsDisplayed(OpenCrm, "Ivo CRM is not displayed");
            bool assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            ClickElement(OpenCrm);

            //Open Company
            assertTopElements = Helpers.IsDisplayed(OpenCompany, "New Company is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            ClickElement(OpenCompany);
            Task.Delay(300).Wait();

            //Contats tab
            Assert.That(Company_ContactsMenu.Text == "Contacts", "Contacts menu is not displayed");
            ClickElement(Company_ContactsMenu);

            //Add contact button
            assertTopElements = Helpers.IsDisplayed(Company_Contacts_AddContactButton, "Contacts type drop-down is not working");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            ClickElement(Company_Contacts_AddContactButton);

            //Contacts type drop-down
            Assert.That(Company_Contacts_Type.Text == "(please select)", "Email type is not displayed");
            ClickElement(Company_Contacts_Type);

            //Check different types of contacts
            Task.Delay(300).Wait();
            Assert.That(Company_Contacts_Type_Email.Text == "Email", "Email type is not displayed");
            Assert.That(Company_Contacts_Type_Facebook.Text == "Facebook", "Facebook type is not displayed");
            Assert.That(Company_Contacts_Type_Phone.Text == "Phone", "Phone type is not displayed");
            Assert.That(Company_Contacts_Type_LinkedIn.Text == "LinkedIn", "LinkedIn type is not displayed");
            ClickElement(Company_Contacts_Type_LinkedIn);

            //Imput contact field
            assertTopElements = Helpers.IsDisplayed(Company_Contacts_ImputContact, "Imput Contact field is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            Company_Contacts_ImputContact.EnterText("drake");

            //Check Close/Save buttons
            Assert.That(Company_Contacts_CloseButton.Text == "Close", "Email type is not displayed");
            assertTopElements = Helpers.IsDisplayed(Company_Contacts_SaveButton, "Save button is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            ClickElement(Company_Contacts_SaveButton);

            //Edit button
            Assert.That(Company_Addresses_EditButton.Text == "Edit", "Save button is not working");
            assertTopElements = Helpers.IsDisplayed(Company_Addresses_EditButton, "New Company is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            ClickElement(Company_Addresses_EditButton);

            //Delete button
            assertTopElements = Helpers.IsDisplayed(Company_Addresses_Edit_DeleteButton, "New Company is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            ClickElement(Company_Addresses_Edit_DeleteButton);

            //Delete button Yes/No
            Assert.That(Company_DeleteButtonNo.Text == "No", "Addresses menu is not displayed");
            Assert.That(Company_DeleteButtonYes.Text == "Yes", "Addresses menu is not displayed");
            ClickElement(Company_DeleteButtonYes);
        }

        public void CompanyPeopleMenu()
        {
            //Open CRM
            string[] assertTopElements = Helpers.IsDisplayed(OpenCrm, "Ivo CRM is not displayed");
            bool assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            ClickElement(OpenCrm);

            //Open Company
            assertTopElements = Helpers.IsDisplayed(OpenCompany, "New Company is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            ClickElement(OpenCompany);
            Task.Delay(300).Wait();

            //Open People menu
            assertTopElements = Helpers.IsDisplayed(Company_PeopleMenu, "People menu is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            ClickElement(Company_PeopleMenu);
            Task.Delay(300).Wait();

            //Check people menu content
            assertTopElements = Helpers.IsDisplayed(Company_People_bucketsSelector_Selected, "BucketsSelector Selected is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);

            assertTopElements = Helpers.IsDisplayed(Company_People_bucketsSelector_Nonselected, "BucketsSelector Nonselected is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
        }

        public void CompanyCommentsMenu()
        {
            //Open CRM
            string[] assertTopElements = Helpers.IsDisplayed(OpenCrm, "Ivo CRM is not displayed");
            bool assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            ClickElement(OpenCrm);

            //Open Company
            assertTopElements = Helpers.IsDisplayed(OpenCompany, "New Company is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            ClickElement(OpenCompany);
            Task.Delay(300).Wait();

            //Open Comments Menu
            Assert.That(Company_CommentsMenu.Text == "Comments (0)", "Comments menu is not displayed");
            ClickElement(Company_CommentsMenu);

            //Add comment field
            assertTopElements = Helpers.IsDisplayed(Company_Comments_AddComent_ImputField, "Add comments field is not working");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            Company_Comments_AddComent_ImputField.EnterText("drake");

            //Add comment button
            assertTopElements = Helpers.IsDisplayed(Company_Comments_AddComent_Button, "Add comments button is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            ClickElement(Company_Comments_AddComent_Button);

            //Edit comment icon
            Task.Delay(300).Wait();
            assertTopElements = Helpers.IsDisplayed(Company_Comments_EditCommentIcon, "Edit Comment Icon is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            ClickElement(Company_Comments_EditCommentIcon);

            //Edit comment field
            assertTopElements = Helpers.IsDisplayed(Company_Comments_EditCommentField, "Edit comments field is not working");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            Company_Comments_EditCommentField.EnterText("drake@abv.bg");

            //Close comment
            Task.Delay(300).Wait();
            assertTopElements = Helpers.IsDisplayed(Company_Comments_EditComment_CloseCommentIcon, "Close Comment Icon is not working");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);

            //Save comment
            assertTopElements = Helpers.IsDisplayed(Company_Comments_EditComment_SaveCommentIcon, "Save Comment Icon is not working");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            ClickElement(Company_Comments_EditComment_SaveCommentIcon);

            //Delete comment
            Task.Delay(300).Wait();
            assertTopElements = Helpers.IsDisplayed(Company_Comments_DeleteCommentIcon, "Delete Comment Icon is not working");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            ClickElement(Company_Comments_DeleteCommentIcon);
            Assert.That(Company_DeleteButtonNo.Text == "No", "Delete Comment button (No) is not working");
            Assert.That(Company_DeleteButtonYes.Text == "Yes", "Delete Comment button (Yes) is not working");
            ClickElement(Company_DeleteButtonYes);
        }

        public void SettingsMenu()
        {
            //Open CRM
            string[] assertTopElements = Helpers.IsDisplayed(OpenCrm, "Ivo CRM is not displayed");
            bool assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            ClickElement(OpenCrm);

            //Open Settings menu
            Task.Delay(300).Wait();
            assertTopElements = Helpers.IsDisplayed(SettingsIcon, "Settings icon is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            ClickElement(SettingsIcon); 

            //Name field
            assertTopElements = Helpers.IsDisplayed(Settings_NameField, "Name field is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            Settings_NameField.EnterText("Ivo123");

            //Check Save button
            assertTopElements = Helpers.IsDisplayed(Settings_SaveButton, "Name field is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);

            //Open Contact Types tab
            assertTopElements = Helpers.IsDisplayed(Settings_ContactTypes, "Name field is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            ClickElement(Settings_ContactTypes);

            //Check Contact Type Email 
            assertTopElements = Helpers.IsDisplayed(Settings_ContactTypes_Email, "Name field is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);

            //Check Contact Type Facebook
            assertTopElements = Helpers.IsDisplayed(Settings_ContactTypes_Facebook, "Name field is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);

            //Check Contact Type Phone
            assertTopElements = Helpers.IsDisplayed(Settings_ContactTypes_Phone, "Name field is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);

            //Check Contact Type LinkedIn
            assertTopElements = Helpers.IsDisplayed(Settings_ContactTypes_LinkedIn, "Name field is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);

            //Close Settings button
            assertTopElements = Helpers.IsDisplayed(Settings_CloseIcon, "Name field is not displayed");
            assertTopElementsResult = assertTopElements[BOOL_INDEX].ToLower() == "true" ? true : false;
            Assert.That(assertTopElementsResult, assertTopElements[ERR_MSG_INDEX]);
            ClickElement(Settings_CloseIcon);
        }
    }
}
