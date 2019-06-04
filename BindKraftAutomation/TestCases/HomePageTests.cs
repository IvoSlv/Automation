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

        [Test, Order(13)]
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

       [Test, Order(14)]
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

        [Test, Order(15)]
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

        [Test, Order(16)]
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

        [Test, Order(17)]
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

       

       // [Test, Order(20)]
        [Retry(1)]
        public void HamburgerMenuTest()
        {
            test = extent.CreateTest("Hamburger Menu Test");
            this.homePage.GoToLoginPage();

            var loginPage = new LoginPage(driver);
            loginPage.LoginToApplication("LogInTest");

            var HomePage = new HomePage(driver);
            HomePage.HamburgerMenu();
        }

        [Test, Order(20)]
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

        [Test, Order(20)]
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

        [Test, Order(20)]
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

        [Test, Order(20)]
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
