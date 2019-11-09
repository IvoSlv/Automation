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
        private static string _driverPath = Environment.CurrentDirectory.ToString() + "\\Drivers\\ChromeDriver";
        internal IWebDriver driver;
        internal ExtentHtmlReporter htmlReport;
        internal static ExtentReports extent = new ExtentReports();
        internal static ExtentTest test;
        private int waitSeconds;

        public int WaitSeconds
        {
            get
            {
                return waitSeconds;
            }
            set
            {
                if (0 > value || value > 60)
                {
                    throw new Exception("Wait seconds can't be less than 0 or more than a minute.");
                }
                waitSeconds = value;
            }
        }

        internal void InitDriver(string url = Constants.BINDKRAFT_URL)
        {
            this.driver = new ChromeDriver(_driverPath);
            this.driver.Url = url;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            initReporter();
        }

        /// <summary>
        /// Click element when its displayed
        /// </summary>
        /// <param name="el">Main element to click</param>
        /// <param name="close">If this is some sort of a pop-up, element to click for close</param>
        /// <param name="waitSeconds">Time to wait for element to be displayed</param>
        public void ClickElement(IWebElement el, IWebElement close = null, int waitSeconds = 10)
        {
            this.WaitSeconds = waitSeconds;

            try
            {
                var clickableElement = GetDisplayedElement(el);
                clickableElement.Click();

                if (close != null)
                {
                    clickableElement = GetDisplayedElement(close);
                    clickableElement.Click();
                }
            }
            catch (Exception ex)
            {
                CloseAllDrivers();
                throw ex;
            }
        }

        public IWebElement GetDisplayedElement(IWebElement el)
        {
            IWebElement resultElement = null;

            for (int i = 0; i < WaitSeconds; i++)
            {
                Task.Delay(1000).Wait();
                try
                {
                    if (el.Displayed)
                    {
                        resultElement = el;
                        return resultElement;
                    }
                }
                catch (Exception)
                {
                    //Swallow
                }
            }

            return resultElement;
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
