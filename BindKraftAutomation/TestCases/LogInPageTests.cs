﻿using BindKraftAutomation.PageObject;
using NUnit.Framework;
using BindKraftAutomation.Models;
using NUnit.Framework.Interfaces;
using AventStack.ExtentReports;

namespace BindKraftAutomation.TestCases
{
    [TestFixture]
    [Order(2)]
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

        [Test, Order(4)]
        [Retry(2)]
        public void LoginTest()
        {
            test = extent.CreateTest("Log in Test");
            this.homePage.GoToLoginPage();

            var loginPage = new LoginPage(driver);
            loginPage.LoginToApplication("LogInTest");
        }

        [Test, Order(5)]
        [Retry(2)]
        public void ForgotYourEmailTest()
        {
            test = extent.CreateTest("Forgot Your Email Test");
            this.homePage.GoToLoginPage();

            var loginPage = new LoginPage(driver);
            loginPage.ForgotYourPasword();
        }

        [Test, Order(5)]
        [Retry(2)]
        public void ResendConfirmationTest()
        {
            test = extent.CreateTest("Resend Confirmation Test");
            this.homePage.GoToLoginPage();

            var loginPage = new LoginPage(driver);
            loginPage.ResendConfirmation();
        }

        [Test, Order(5)]
        [Retry(2)]
        public void SignUpWithMicrosoftAccountTest()
        {
            test = extent.CreateTest("Sign Up With Microsoft Account");
            this.homePage.GoToLoginPage();

            var loginPage = new LoginPage(driver);
            loginPage.SignUpWithMicrosoftAcc();
        }

        [Test, Order(5)]
        [Retry(2)]
        public void SignUpWithFacebookAccountTest()
        {
            test = extent.CreateTest("Sign Up With Facebook Account");
            this.homePage.GoToLoginPage();

            var loginPage = new LoginPage(driver);
            loginPage.SignUpWithFacebookAcc();
        }

        [Test, Order(5)]
        [Retry(2)]
        public void SignUpWithGoogleAccountTest()
        {
            test = extent.CreateTest("Sign Up With Google Account");
            this.homePage.GoToLoginPage();

            var loginPage = new LoginPage(driver);
            loginPage.SignUpWithGoogleAcc();
        }

        [Test, Order(5)]
        [Retry(2)]
        public void CreateAccountTest()
        {
            test = extent.CreateTest("Create Account - Form test");
            this.homePage.GoToLoginPage();

            var loginPage = new LoginPage(driver);
            loginPage.CreateAccount();
        }
    }
}
