using BindKraftAutomation.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Configuration;
using OpenQA.Selenium.Chrome;
using BindKraftAutomation.Globals;
using System;
using BindKraftAutomation.Models;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports;

namespace BindKraftAutomation
{
    class LandingPageTests
    {
        private ExtentReports extent = new ExtentReports();
        [Test, Order(1)]
        [Retry(2)]
        public void GoToLoginPageTest()
        {
            var homePage = new LandingPage();
            homePage.GoToLoginPage();

            //The test reporting feature is based in the PageTestBase class.
            //Every test need to have those three steps - Feature -> Scenario -> (not sure the create node is needed, this needs sume further testing)
            
            var feature = extent.CreateTest<Feature>("Go to Login");
            var scenario = feature.CreateNode<Scenario>("Navigation to login");
            scenario.CreateNode<Given>("This is a smoke test to assert the page is up and running");

            //Here further testing is needed as well. This might be needed only on the last test. Practically this creates the file/appends the result tests.
            extent.Flush();
        }

        [Test, Order(2)]
        [Retry(2)]
        public void KraftBoardMenuTest()
        {
            var homePage = new LandingPage();
            homePage.KraftBoardMenu();

            var feature = extent.CreateTest<Feature>("Go to Kraft Board Menu");
            var scenario = feature.CreateNode<Scenario>("Navigation Kraft Board Menu");
            extent.Flush();
        }

        [Test, Order(3)]
        [Retry(2)]
        public void KraftBoardPlansMenuTest()
        {
            var homePage = new LandingPage();
            homePage.KraftBoardPlansMenu();

            var feature = extent.CreateTest<Feature>("Go to Kraft Board Menu Plans");
            var scenario = feature.CreateNode<Scenario>("Navigation Kraft Board Menu Plans");
            extent.Flush();
        }

        [Test, Order(4)]
        [Retry(2)]
        public void KraftCrmMenuTest()
        {
            var homePage = new LandingPage();
            homePage.KraftCrmMenu();
            var feature = extent.CreateTest<Feature>("Go to Kraft Crm Menu");
            var scenario = feature.CreateNode<Scenario>("Navigation Kraft Crm Menu");
            extent.Flush();
        }

        [Test, Order(5)]
        [Retry(2)]
        public void KraftCrmPlansMenuTest()
        {
            var homePage = new LandingPage();
            homePage.KraftCrmPlansMenu();
            var feature = extent.CreateTest<Feature>("Go to Kraft Crm Plans Menu");
            var scenario = feature.CreateNode<Scenario>("Navigation Crm Plans Menu");
            extent.Flush();
        }

        [Test, Order(6)]
        [Retry(2)]
        public void FeaturesMenuTest()
        {
            var homePage = new LandingPage();
            homePage.FeaturesMenu();
            var feature = extent.CreateTest<Feature>("Go to Kraft Features Menu");
            var scenario = feature.CreateNode<Scenario>("Navigation Features Menu");
            extent.Flush();
        }

        [Test, Order(7)]
        [Retry(2)]
        public void TermsOfUse_PrivacyPollicyTest()
        {
            var homePage = new LandingPage();
            homePage.TermsOfUse_PrivacyPollicy();
            var feature = extent.CreateTest<Feature>("Go to Privacy Policy");
            var scenario = feature.CreateNode<Scenario>("Navigation Privacy Policy");
            extent.Flush();
        }

        [Test, Order(8)]
        [Retry(2)]
        public void Certificate1Test()
        {
            var homePage = new LandingPage();
            homePage.Certificate1();
            var feature = extent.CreateTest<Feature>("Go to Certificate 1");
            var scenario = feature.CreateNode<Scenario>("Navigation Certificate 1");
            extent.Flush();
        }

        [Test, Order(9)]
        [Retry(2)]
        public void Certificate2Test()
        {
            var homePage = new LandingPage();
            homePage.Certificate2();
            var feature = extent.CreateTest<Feature>("Go to Certificate 2");
            var scenario = feature.CreateNode<Scenario>("Navigation Certificate 2");
            extent.Flush();
        }
    }
}
