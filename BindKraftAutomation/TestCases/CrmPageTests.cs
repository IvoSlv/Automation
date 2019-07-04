using BindKraftAutomation.PageObject;
using NUnit.Framework;
using BindKraftAutomation.Models;
using NUnit.Framework.Interfaces;
using AventStack.ExtentReports;

namespace BindKraftAutomation.TestCases
{
    [TestFixture]
    [Order(4)]
    class CrmPageTests : PageTestBase
    {
        private LandingPage homePage;

        [SetUp]
        public void setUp()
        {
            InitDriver();
            homePage = new LandingPage(this.driver);
        }

        [TearDown]
        public void tearDown()
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var errorMessage = TestContext.CurrentContext.Result.Message;

            if (status == TestStatus.Failed)
            {
                test.Log(Status.Fail, status + errorMessage);
            }

            CloseAllDrivers();
        }

        [OneTimeTearDown]
        public void oneTimeTear()
        {
            extent.Flush();
        }

        [Test, Order(10)]
        [Retry(2)]
        public void CheckMainTabsAndOptionsTest()
        {
            test = extent.CreateTest("Check Main Tabs And Options Test");
            this.homePage.GoToLoginPage();

            var loginPage = new LoginPage(driver);
            loginPage.LoginToApplication("LogInTest");

            var HomePage = new HomePage(driver);
            HomePage.GoToCrm();

            var CrmPage = new CrmPage(driver);
            CrmPage.CheckMainTabsAndOptions();
        }

        [Test, Order(11)]
        [Retry(2)]
        public void CreateCompanyTest()
        {
            test = extent.CreateTest("Create Company Test");
            this.homePage.GoToLoginPage();

            var loginPage = new LoginPage(driver);
            loginPage.LoginToApplication("LogInTest");

            var HomePage = new HomePage(driver);
            HomePage.GoToCrm();

            var CrmPage = new CrmPage(driver);
            CrmPage.CreateCompany();
        }

        [Test, Order(12)]
        [Retry(2)]
        public void CheckCompanyTabs()
        {
            test = extent.CreateTest("Check Company Menus Test");
            this.homePage.GoToLoginPage();

            var loginPage = new LoginPage(driver);
            loginPage.LoginToApplication("LogInTest");

            var HomePage = new HomePage(driver);
            HomePage.GoToCrm();

            var CrmPage = new CrmPage(driver);
            CrmPage.CheckCompanyMenus();
        }

        [Test, Order(13)]
        [Retry(2)]
        public void CompanyMenuTest()
        {
            test = extent.CreateTest("Company Menu Test");
            this.homePage.GoToLoginPage();

            var loginPage = new LoginPage(driver);
            loginPage.LoginToApplication("LogInTest");

            var HomePage = new HomePage(driver);
            HomePage.GoToCrm();

            var CrmPage = new CrmPage(driver);
            CrmPage.CompanyMenu();
        }

        [Test, Order(14)]
        [Retry(2)]
        public void CompanyAddressesMenuTest()
        {
            test = extent.CreateTest("Addresses Menu Test");
            this.homePage.GoToLoginPage();

            var loginPage = new LoginPage(driver);
            loginPage.LoginToApplication("LogInTest");

            var HomePage = new HomePage(driver);
            HomePage.GoToCrm();

            var CrmPage = new CrmPage(driver);
            CrmPage.CompanyAddressesMenu();
        }

        [Test, Order(15)]
        [Retry(2)]
        public void CompanyContactsMenuTest()
        {
            test = extent.CreateTest("Contacts Menu Test");
            this.homePage.GoToLoginPage();

            var loginPage = new LoginPage(driver);
            loginPage.LoginToApplication("LogInTest");

            var HomePage = new HomePage(driver);
            HomePage.GoToCrm();

            var CrmPage = new CrmPage(driver);
            CrmPage.CompanyContactsMenu();
        }

        [Test, Order(16)]
        [Retry(2)]
        public void CompanyPeopleMenuTest()
        {
            test = extent.CreateTest("People Menu Test");
            this.homePage.GoToLoginPage();

            var loginPage = new LoginPage(driver);
            loginPage.LoginToApplication("LogInTest");

            var HomePage = new HomePage(driver);
            HomePage.GoToCrm();

            var CrmPage = new CrmPage(driver);
            CrmPage.CompanyPeopleMenu();
        }

        [Test, Order(17)]
        [Retry(2)]
        public void CompanyCommentsMenuTest()
        {
            test = extent.CreateTest("Comments Menu Test");
            this.homePage.GoToLoginPage();

            var loginPage = new LoginPage(driver);
            loginPage.LoginToApplication("LogInTest");

            var HomePage = new HomePage(driver);
            HomePage.GoToCrm();

            var CrmPage = new CrmPage(driver);
            CrmPage.CompanyCommentsMenu();
        }

        [Test, Order(18)]
        [Retry(2)]
        public void CrmSettingsTest()
        {
            test = extent.CreateTest("Comments Menu Test");
            this.homePage.GoToLoginPage();

            var loginPage = new LoginPage(driver);
            loginPage.LoginToApplication("LogInTest");

            var HomePage = new HomePage(driver);
            HomePage.GoToCrm();

            var CrmPage = new CrmPage(driver);
            CrmPage.SettingsMenu();
        }
    }
}
