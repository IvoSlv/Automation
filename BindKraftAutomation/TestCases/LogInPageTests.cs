using BindKraftAutomation.PageObject;
using NUnit.Framework;
using BindKraftAutomation.Models;
using NUnit.Framework.Interfaces;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;

namespace BindKraftAutomation.TestCases
{
    [TestFixture]
    class LogInPageTests : PageTestBase
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
        public void LoginTest()
        {
            test = extent.CreateTest("Log in Test");
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
            test = extent.CreateTest("Forgot Your Email Test");
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
            test = extent.CreateTest("Resend Confirmation Test");
            this.homePage.GoToLoginPage();

            var loginPage = new LoginPage(driver);
            loginPage.ResendConfirmation();

            var feature = extent.CreateTest<Feature>("Resend Confirmation");
            var scenario = feature.CreateNode<Scenario>("Scenario");
            scenario.CreateNode<Given>("Steps...");
        }

        [Test, Order(12)]
        [Retry(2)]
        public void SignUpWithMicrosoftAccountTest()
        {
            test = extent.CreateTest("Sign Up With Microsoft Account");
            this.homePage.GoToLoginPage();

            var loginPage = new LoginPage(driver);
            loginPage.SignUpWithMicrosoftAcc();

            var feature = extent.CreateTest<Feature>("Sign Up With Microsoft Account");
            var scenario = feature.CreateNode<Scenario>("Scenario");
            scenario.CreateNode<Given>("Steps...");
        }

        [Test, Order(12)]
        [Retry(2)]
        public void SignUpWithFacebookAccountTest()
        {
            test = extent.CreateTest("Sign Up With Facebook Account");
            this.homePage.GoToLoginPage();

            var loginPage = new LoginPage(driver);
            loginPage.SignUpWithFacebookAcc();

            var feature = extent.CreateTest<Feature>("Sign Up With Facebook Account");
            var scenario = feature.CreateNode<Scenario>("Scenario");
            scenario.CreateNode<Given>("Steps...");
        }

        [Test, Order(12)]
        [Retry(2)]
        public void SignUpWithGoogleAccountTest()
        {
            test = extent.CreateTest("Sign Up With Google Account");
            this.homePage.GoToLoginPage();

            var loginPage = new LoginPage(driver);
            loginPage.SignUpWithGoogleAcc();

            var feature = extent.CreateTest<Feature>("Sign Up With Google Account");
            var scenario = feature.CreateNode<Scenario>("Scenario");
            scenario.CreateNode<Given>("Steps...");
        }
    }
}
