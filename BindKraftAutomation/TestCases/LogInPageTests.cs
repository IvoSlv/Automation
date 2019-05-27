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
    class LogInPageTests : PageTestBase
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

        [Test, Order(10)]
        [Retry(2)]
        public void LoginTest()
        {
            test = extent.CreateTest("LoginTest");
            this.homePage.GoToLoginPage();

            var loginPage = new LoginPage(driver);
            loginPage.LoginToApplication("LogInTest");

            var feature = extent.CreateTest<Feature>("Login to apps");
            var scenario = feature.CreateNode<Scenario>("Scenario");
            scenario.CreateNode<Given>("Steps...");
        }

        [Test, Order(11)]
        [Retry(2)]
        public void ForgotYourEmailTest()
        {
            test = extent.CreateTest("ForgotYourEmailTest");
            this.homePage.GoToLoginPage();

            var loginPage = new LoginPage(driver);
            loginPage.ForgotYourPasword();

            var feature = extent.CreateTest<Feature>("Forgot your email");
            var scenario = feature.CreateNode<Scenario>("Scenario");
            scenario.CreateNode<Given>("Steps...");
        }

        [Test, Order(12)]
        [Retry(2)]
        public void ResendConfirmationTest()
        {
            test = extent.CreateTest("ResendConfirmationTest");
            this.homePage.GoToLoginPage();

            var loginPage = new LoginPage(driver);
            loginPage.ResendConfirmation();

            var feature = extent.CreateTest<Feature>("Resend Confirmation");
            var scenario = feature.CreateNode<Scenario>("Scenario");
            scenario.CreateNode<Given>("Steps...");
        }
    }
}
