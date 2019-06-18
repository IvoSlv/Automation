﻿using BindKraftAutomation.PageObject;
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
    }
}
