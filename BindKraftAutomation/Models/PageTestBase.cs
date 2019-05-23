using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using BindKraftAutomation.Globals;
using BindKraftAutomation.PageObject;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BindKraftAutomation.Models
{
    public abstract class PageTestBase
    {
        internal IWebDriver driver;
        internal LandingPage homePage;
        internal ExtentHtmlReporter htmlReport = new ExtentHtmlReporter(@"C:\Users\islavchev\source\repos\Automate\TestResults\Report.html");
        internal ExtentReports extent = new ExtentReports();

        internal void InitDriver(string url = Constants.BINDKRAFT_URL)
        {
            this.driver = new ChromeDriver(Constants.chromeDriverPath);
            this.driver.Url = url;
            this.homePage = new LandingPage(this.driver);
            htmlReport.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            extent.AttachReporter(htmlReport);
        }

        public void ClickElement(IWebElement el, IWebElement close = null)
        {
            try
            {
                var clickableElement = new WebDriverWait(driver, TimeSpan.FromSeconds(2)).Until(ExpectedConditions.ElementToBeClickable(el));
                Thread.Sleep(200);
                clickableElement.Click();

                if (close != null)
                {
                    clickableElement = new WebDriverWait(driver, TimeSpan.FromSeconds(1)).Until(ExpectedConditions.ElementToBeClickable(close));
                    Thread.Sleep(100);
                    clickableElement.Click();
                }
            }
            catch (Exception ex)
            {
                driver.Close();
                driver.Dispose();
                throw ex;
            }
        }

        public void CloseAllDrivers()
        {
                this.driver.Close();
                this.driver.Dispose();
        }
    }
}
