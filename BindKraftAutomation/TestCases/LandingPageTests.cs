using NUnit.Framework;
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

        /*
             * The test reporting feature is based in the PageTestBase class.
             * Every test need to have those three steps - Feature -> Scenario -> Nodes
             */

        [Test, Order(1)]
        public void GoToLoginPageTest()
        {
            test = extent.CreateTest("Go To Login Page Test");
            homePage.GoToLoginPage();
        }

        [Test, Order(2)]
        [Retry(2)]
        public void TopNavigationMenuTest()
        {
            test = extent.CreateTest("Top Navigation Menu Test");
            this.homePage.TopNavigationMenu();
        }


        [Test, Order(3)]
        [Retry(2)]
        public void KraftBoardMenuTest()
        {
            test = extent.CreateTest("KraftBoard Menu Test");
            this.homePage.KraftBoardMenu();
        }

       // [Test, Order(3)]
        [Retry(2)]
        public void KraftBoardPlansMenuTest()
        {
            test = extent.CreateTest("KraftBoardPlansMenuTest");
            this.homePage.KraftBoardPlansMenu();
        }

       // [Test, Order(4)]
        [Retry(2)]
        public void KraftCrmMenuTest()
        {
            test = extent.CreateTest("KraftCrmMenuTest");
            this.homePage.KraftCrmMenu();
        }

        //[Test, Order(5)]
        [Retry(2)]
        public void KraftCrmPlansMenuTest()
        {
            test = extent.CreateTest("KraftCrm Plans Menu Test");
            this.homePage.KraftCrmPlansMenu();
        }

        //[Test, Order(6)]
        [Retry(2)]
        public void FeaturesMenuTest()
        {
            test = extent.CreateTest("Features Menu Test");
            this.homePage.FeaturesMenu();
        }

        [Test, Order(4)]
        [Retry(2)]
        public void TermsOfUse_PrivacyPollicyTest()
        {
            test = extent.CreateTest("Terms Of Use Privacy Pollicy Test");
            this.homePage.TermsOfUse_PrivacyPollicy();
        }

        [Test, Order(5)]
        [Retry(2)]
        public void Certificate1Test()
        {
            test = extent.CreateTest("Certificate1 Test");
            this.homePage.Certificate1();
        }

        [Test, Order(6)]
        [Retry(2)]
        public void Certificate2Test()
        {
            test = extent.CreateTest("Certificate2 Test");
            this.homePage.Certificate2();
        }

        [OneTimeTearDown]
        public void oneTimeTear()
        {
            extent.Flush();
        }
    }
}
