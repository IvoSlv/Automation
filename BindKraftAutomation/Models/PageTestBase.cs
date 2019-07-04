using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using BindKraftAutomation.Globals;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;

namespace BindKraftAutomation.Models
{
    public abstract class PageTestBase
    {
        internal IWebDriver driver;
        internal ExtentHtmlReporter htmlReport;
        internal static ExtentReports extent = new ExtentReports();
        internal static ExtentTest test;
        
        internal void InitDriver(string url = Constants.BINDKRAFT_URL)
        {
            this.driver = new ChromeDriver();
            this.driver.Url = url;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            initReporter();
        }

        /// <summary>
        /// Click element when its displayed
        /// </summary>
        /// <param name="el">Main element to click</param>
        /// <param name="close">If this is some sort of a pop-up, element to click for close</param>
        public void ClickElement(IWebElement el, IWebElement close = null)
        {
            try
            {
                var clickableElement = new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementToBeClickable(el));
                Task.Delay(300).Wait();
                clickableElement.Click();

                if (close != null)
                {
                    clickableElement = new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementToBeClickable(close));
                    Task.Delay(300).Wait();
                    clickableElement.Click();
                }
            }
            catch (Exception ex)
            {
                CloseAllDrivers();
                throw ex;
            }
        }

        public void initReporter()
        {
            if (this.htmlReport != null)
            {
                return;
            }

            try
            {
                var rootPath = new DirectoryInfo(
                    Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location))
                    .Parent.Parent.Parent;
                var date = DateTime.UtcNow.ToString().Replace(' ', '-').Replace(':', '.').Replace('/', '.').Replace('\\', '.');
                var path = rootPath.FullName + @"\TestResults\Test " + date;
                Directory.CreateDirectory(path);
                this.htmlReport = new ExtentHtmlReporter(path + "\\");
                htmlReport.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
                extent.AttachReporter(htmlReport);
            }
            catch (Exception)
            {
                //TODO: Log the error
            }

        }

        public void CloseAllDrivers()
        {
            this.driver.Close();
            this.driver.Dispose();
        }
    }
}
