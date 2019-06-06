using BindKraftAutomation.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Configuration;
using OpenQA.Selenium.Chrome;
using BindKraftAutomation.Models;
using NUnit.Framework.Interfaces;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using System.Threading.Tasks;

namespace BindKraftAutomation.TestCases
{
    [TestFixture]
    class HomePageTests : PageTestBase
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

        [Test, Order(6)]
        [Retry(2)]
        public void GoToBoardTest()
        {
            test = extent.CreateTest("Go To KraftBoard Test");
            this.homePage.GoToLoginPage();

            var loginPage = new LoginPage(driver);
            loginPage.LoginToApplication("LogInTest");

            var HomePage = new HomePage(driver);
            HomePage.GoToBoard();
        }

       [Test, Order(6)]
        [Retry(2)]
        public void GoToCrmTest()
        {
            test = extent.CreateTest("Go To KraftCRM Test");
            this.homePage.GoToLoginPage();

            var loginPage = new LoginPage(driver);
            loginPage.LoginToApplication("LogInTest");

            var HomePage = new HomePage(driver);
            HomePage.GoToCrm();
        }

        [Test, Order(6)]
        [Retry(2)]
        public void GoToHrmTest()
        {
            test = extent.CreateTest("GoToHrmTest");
            this.homePage.GoToLoginPage();

            var loginPage = new LoginPage(driver);
            loginPage.LoginToApplication("LogInTest");

            var HomePage = new HomePage(driver);
            HomePage.GoToHrm();
        }

        [Test, Order(6)]
        [Retry(2)]
        public void OpenUserOptionMenuTest()
        {
            test = extent.CreateTest("Open User Option Menu Test");
            this.homePage.GoToLoginPage();

            var loginPage = new LoginPage(driver);
            loginPage.LoginToApplication("LogInTest");
            
            var HomePage = new HomePage(driver);
            HomePage.OpenUserOptionMenu();
        }

        [Test, Order(7)]
        [Retry(2)]
        public void UserProfileMenuTest()
        {
            test = extent.CreateTest("User Profile Menu Test");
            this.homePage.GoToLoginPage();

            var loginPage = new LoginPage(driver);
            loginPage.LoginToApplication("LogInTest");

            var HomePage = new HomePage(driver);
            HomePage.UserProfileMenu();
        }
        
        [Test, Order(6)]
        [Retry(2)]
        public void HamburgerMenuTestElements()
        {
            test = extent.CreateTest("Hamburger Menu Test Elements");
            this.homePage.GoToLoginPage();

            var loginPage = new LoginPage(driver);
            loginPage.LoginToApplication("LogInTest");

            var HomePage = new HomePage(driver);
            HomePage.HamburgerMenu();
        }

        [Test, Order(8)]
        [Retry(2)]
        public void HamburgerMenu_GoToKraftBoardTest()
        {
            test = extent.CreateTest("Hamburger Menu Go To KraftBoard Test");
            this.homePage.GoToLoginPage();

            var loginPage = new LoginPage(driver);
            loginPage.LoginToApplication("LogInTest");

            var HomePage = new HomePage(driver);
            HomePage.HamburgerMenu_GoToKraftBoard();
        }

        [Test, Order(8)]
        [Retry(2)]
        public void HamburgerMenu_GoToKraftCrmTest()
        {
            test = extent.CreateTest("Hamburger Menu Go To KraftCrm");
            this.homePage.GoToLoginPage();

            var loginPage = new LoginPage(driver);
            loginPage.LoginToApplication("LogInTest");

            var HomePage = new HomePage(driver);
            HomePage.HamburgerMenu_GoToKraftCrm();
        }

        [Test, Order(8)]
        [Retry(2)]
        public void HamburgerMenu_GoToKraftHrmTest()
        {
            test = extent.CreateTest("Hamburger Menu_Go To KraftHrm");
            this.homePage.GoToLoginPage();

            var loginPage = new LoginPage(driver);
            loginPage.LoginToApplication("LogInTest");

            var HomePage = new HomePage(driver);
            HomePage.HamburgerMenu_GoToKraftHrm();
        }

        [Test, Order(8)]
        [Retry(2)]
        public void HamburgerMenu_ClickHomeButtonTest()
        {
            test = extent.CreateTest("Hamburger Menu Click Home Button");
            this.homePage.GoToLoginPage();

            var loginPage = new LoginPage(driver);
            loginPage.LoginToApplication("LogInTest");

            var HomePage = new HomePage(driver);
            HomePage.HamburgerMenu_ClickHomeButton();
        }

        [Test, Order(6)]
        [Retry(2)]
        public void NotificationMenuTest()
        {
            test = extent.CreateTest("Notification Menu Test");
            this.homePage.GoToLoginPage();

            var loginPage = new LoginPage(driver);
            loginPage.LoginToApplication("LogInTest");
            
            var HomePage = new HomePage(driver);
            HomePage.CheckNotificationMenu();
        }

        [Test, Order(6)]
        [Retry(2)]
        public void GoToKraftUsersGuideTest()
        {
            test = extent.CreateTest("Go To Kraft Users Guide Test");
            this.homePage.GoToLoginPage();

            var loginPage = new LoginPage(driver);
            loginPage.LoginToApplication("LogInTest");

            var HomePage = new HomePage(driver);
            HomePage.GoToKraftUsersGuide();
        }

        [Test, Order(7)]
        [Retry(2)]
        public void LogoutTest()
        {
            test = extent.CreateTest("Logout Test");
            this.homePage.GoToLoginPage();

            var loginPage = new LoginPage(driver);
            loginPage.LoginToApplication("LogInTest");

            var HomePage = new HomePage(driver);
            HomePage.Logout();
        }

        [Test, Order(7)]
        [Retry(2)]
        public void NotificationSetingsTest()
        {
            test = extent.CreateTest("Notification Setings Test");
            this.homePage.GoToLoginPage();

            var loginPage = new LoginPage(driver);
            loginPage.LoginToApplication("LogInTest");

            var HomePage = new HomePage(driver);
            HomePage.NotificationSettings();
        }
    }
}
