using BindKraftAutomation.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Configuration;
using OpenQA.Selenium.Chrome;
using BindKraftAutomation.Models;
using NUnit.Framework.Interfaces;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;

namespace BindKraftAutomation.TestCases
{
    [TestFixture]
    class HomePageTests : PageTestBase
    {
        [SetUp]
        public void setUp()
        {
            InitDriver();
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
            test = extent.CreateTest("GoToBoardTest");
            this.homePage.GoToLoginPage();

            var loginPage = new LoginPage(driver);
            loginPage.LoginToApplication("LogInTest");

            var HomePage = new HomePage(driver);
            HomePage.GoToBoard();

            var feature = extent.CreateTest<Feature>("Go to Board home page");
            var scenario = feature.CreateNode<Scenario>("Scenario");
            scenario.CreateNode<Given>("Steps...");
        }

        [Test, Order(14)]
        [Retry(2)]
        public void GoToCrmTest()
        {
            test = extent.CreateTest("GoToCrmTest");
            this.homePage.GoToLoginPage();

            var loginPage = new LoginPage(driver);
            loginPage.LoginToApplication("LogInTest");

            var HomePage = new HomePage(driver);
            HomePage.GoToCrm();

            var feature = extent.CreateTest<Feature>("Go to CRM home page");
            var scenario = feature.CreateNode<Scenario>("Scenario");
            scenario.CreateNode<Given>("Steps...");
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

            var feature = extent.CreateTest<Feature>("Go to HRM home page");
            var scenario = feature.CreateNode<Scenario>("Scenario");
            scenario.CreateNode<Given>("Steps...");
        }

        [Test, Order(16)]
        [Retry(2)]
        public void OpenUserProfileMenu()
        {
            test = extent.CreateTest("OpenHomePageMenuTest");
            this.homePage.GoToLoginPage();

            var loginPage = new LoginPage(driver);
            loginPage.LoginToApplication("LogInTest");

            var feature = extent.CreateTest<Feature>("Open homepage menu");
            var scenario = feature.CreateNode<Scenario>("Scenario");
            
            var HomePage = new HomePage(driver);
            HomePage.OpenUserProfileMenu();

            scenario.CreateNode<Given>("Steps...");
        }
    }
}
