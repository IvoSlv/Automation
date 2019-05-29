﻿using NUnit.Framework;
using BindKraftAutomation.Models;
using AventStack.ExtentReports.Gherkin.Model;
using NUnit.Framework.Interfaces;
using AventStack.ExtentReports;
using BindKraftAutomation.PageObject;

namespace BindKraftAutomation
{
    [TestFixture]
    class LandingPageTests : PageTestBase
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

        [Test, Order(1)]
        public void GoToLoginPageTest()
        {
            /*
             * The test reporting feature is based in the PageTestBase class.
             * Every test need to have those three steps - Feature -> Scenario -> Nodes
             */
            test = extent.CreateTest("GoToLoginPageTest");
            homePage.GoToLoginPage();
            var feature = extent.CreateTest<Feature>("Go to Login");
            var scenario = feature.CreateNode<Scenario>("Navigation to login");
        }

        [Test, Order(2)]
        [Retry(2)]
        public void TopNavigationMenuTest()
        {
            test = extent.CreateTest("TopNavigationMenuTest");
            this.homePage.TopNavigationMenu();
            var feature = extent.CreateTest<Feature>("Check Top Navigation Menu is visible");
            var scenario = feature.CreateNode<Scenario>("Scenario");
            scenario.CreateNode<Given>("Steps...");
        }


        [Test, Order(2)]
        [Retry(2)]
        public void KraftBoardMenuTest()
        {
            test = extent.CreateTest("KraftBoardMenuTest");
            this.homePage.KraftBoardMenu();
            var feature = extent.CreateTest<Feature>("Go to Board");
            var scenario = feature.CreateNode<Scenario>("Scenario");
            scenario.CreateNode<Given>("Steps...");
        }

        [Test, Order(3)]
        [Retry(2)]
        public void KraftBoardPlansMenuTest()
        {
            test = extent.CreateTest("KraftBoardPlansMenuTest");
            this.homePage.KraftBoardPlansMenu();
            var feature = extent.CreateTest<Feature>("Go to Board Menu");
            var scenario = feature.CreateNode<Scenario>("Scenario");
            scenario.CreateNode<Given>("Steps...");
        }

        [Test, Order(4)]
        [Retry(2)]
        public void KraftCrmMenuTest()
        {
            test = extent.CreateTest("KraftCrmMenuTest");
            this.homePage.KraftCrmMenu();
            var feature = extent.CreateTest<Feature>("Go to CRM Menu");
            var scenario = feature.CreateNode<Scenario>("Scenario");
            scenario.CreateNode<Given>("Steps...");
        }

        [Test, Order(5)]
        [Retry(2)]
        public void KraftCrmPlansMenuTest()
        {
            test = extent.CreateTest("KraftCrmPlansMenuTest");
            this.homePage.KraftCrmPlansMenu();
            var feature = extent.CreateTest<Feature>("Go to CRM Plans");
            var scenario = feature.CreateNode<Scenario>("Scenario");
            scenario.CreateNode<Given>("Steps...");
        }

        [Test, Order(6)]
        [Retry(2)]
        public void FeaturesMenuTest()
        {
            test = extent.CreateTest("FeaturesMenuTest");
            this.homePage.FeaturesMenu();
            var feature = extent.CreateTest<Feature>("Go to Feature Menu");
            var scenario = feature.CreateNode<Scenario>("Scenario");
            scenario.CreateNode<Given>("Steps...");
        }

        [Test, Order(7)]
        [Retry(2)]
        public void TermsOfUse_PrivacyPollicyTest()
        {
            test = extent.CreateTest("TermsOfUse_PrivacyPollicyTest");
            this.homePage.TermsOfUse_PrivacyPollicy();
            var feature = extent.CreateTest<Feature>("Go to Privacy Policy");
            var scenario = feature.CreateNode<Scenario>("Scenario");
            scenario.CreateNode<Given>("Steps...");
        }

        [Test, Order(8)]
        [Retry(2)]
        public void Certificate1Test()
        {
            test = extent.CreateTest("Certificate1Test");
            this.homePage.Certificate1();
            var feature = extent.CreateTest<Feature>("Go certificate one");
            var scenario = feature.CreateNode<Scenario>("Scenario");
            scenario.CreateNode<Given>("Steps...");
        }

        [Test, Order(9)]
        [Retry(2)]
        public void Certificate2Test()
        {
            test = extent.CreateTest("Go to certificate two");
            this.homePage.Certificate2();
            var feature = extent.CreateTest<Feature>("Go to Board Menu");
            var scenario = feature.CreateNode<Scenario>("Scenario");
            scenario.CreateNode<Given>("Steps...");
        }

        [OneTimeTearDown]
        public void oneTimeTear()
        {
            extent.Flush();
        }
    }
}
