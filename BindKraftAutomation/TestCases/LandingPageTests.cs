﻿using BindKraftAutomation.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Configuration;
using OpenQA.Selenium.Chrome;
using BindKraftAutomation.Globals;
using System;
using BindKraftAutomation.Models;
using AventStack.ExtentReports.Gherkin.Model;

namespace BindKraftAutomation
{
    class LandingPageTests : PageTestBase
    {
        [Test, Order(1)]
        [Retry(2)]
        public void GoToLoginPageTest()
        {
            InitDriver();
            this.homePage.GoToLoginPage();
            this.driver.Dispose();
            
            //The test reporting feature is based in the PageTestBase class.
            //Every test need to have those three steps - Feature -> Scenario -> (not sure the create node is needed, this needs sume further testing)
            var feature = extent.CreateTest<Feature>("Go to Login");
            var scenario = feature.CreateNode<Scenario>("Navigation to login");
            scenario.CreateNode<Given>("I naviggate to login page");

            //Here further testing is needed as well. This might be needed only on the last test. Practically this creates the file/appends the result tests.
            extent.Flush();
        }

        [Test, Order(2)]
        [Retry(2)]
        public void KraftBoardMenuTest()
        {
            InitDriver();
            this.homePage.KraftBoardMenu();
            this.driver.Dispose();
        }

        [Test, Order(3)]
        [Retry(2)]
        public void KraftBoardPlansMenuTest()
        {
            InitDriver();
            this.homePage.KraftBoardPlansMenu();
            this.driver.Dispose();
        }

        [Test, Order(4)]
        [Retry(2)]
        public void KraftCrmMenuTest()
        {
            InitDriver();
            this.homePage.KraftCrmMenu();
            this.driver.Dispose();
        }

        [Test, Order(5)]
        [Retry(2)]
        public void KraftCrmPlansMenuTest()
        {
            InitDriver();
            this.homePage.KraftCrmPlansMenu();
            this.driver.Dispose();
        }

        [Test, Order(6)]
        [Retry(2)]
        public void FeaturesMenuTest()
        {
            InitDriver();
            this.homePage.FeaturesMenu();
            this.driver.Dispose();
        }

        [Test, Order(7)]
        [Retry(2)]
        public void TermsOfUse_PrivacyPollicyTest()
        {
            InitDriver();
            this.homePage.TermsOfUse_PrivacyPollicy();
            this.driver.Dispose();
        }

        [Test, Order(8)]
        [Retry(2)]
        public void Certificate1Test()
        {
            InitDriver();
            this.homePage.Certificate1();
            this.driver.Dispose();
        }

        [Test, Order(9)]
        [Retry(2)]
        public void Certificate2Test()
        {
            InitDriver();
            this.homePage.Certificate2();
            this.driver.Dispose();
        }
    }
}
