using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using BindKraftAutomation.Globals;
using BindKraftAutomation.PageObject;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindKraftAutomation.Models
{
    public abstract class PageTestBase
    {
        internal IWebDriver driver;
        internal LandingPage homePage;
        internal ExtentHtmlReporter htmlReport = new ExtentHtmlReporter(@"C:\Users\kantonov\Source\repos\Automation\TestResults\Report.html");
        internal ExtentReports extent = new ExtentReports();

        internal void InitDriver(string url = Constants.BINDKRAFT_URL)
        {
            this.driver = new ChromeDriver(Constants.chromeDriverPath);
            this.driver.Url = url;
            this.homePage = new LandingPage(this.driver);
            htmlReport.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            extent.AttachReporter(htmlReport);
        }

    }
}
