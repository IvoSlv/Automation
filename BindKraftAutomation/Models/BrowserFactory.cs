using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using BindKraftAutomation.Globals;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;

namespace BindKraftAutomation.Models
{
    //Under construction
    class BrowserFactory
    {
        private static string _driverPath = AppDomain.CurrentDomain.BaseDirectory;
        internal static IWebDriver driver;     
        private static readonly IDictionary<string, IWebDriver> Drivers = new Dictionary<string, IWebDriver>();

        public static IWebDriver Driver
        {
            get
            {
                if (driver == null)
                    throw new NullReferenceException("The WebDriver browser instance was not initialized. You should first call the method InitBrowser.");
                return driver;
            }
            private set
            {
                driver = value;
            }
        }

        public static void InitBrowser(string browserName)
        {
            switch (browserName)
            {
                case "Chrome":
                    if(Driver == null)
                    {
                        driver = new ChromeDriver(_driverPath);
                        Drivers.Add("Chrome",Driver);
                    }
                    break;

                case "IE":
                    if(Driver == null)
                    {
                        driver = new InternetExplorerDriver("");
                        Drivers.Add("IE", Driver);
                    }
                    break;
                case "Firefox":
                    if(Driver == null)
                    {
                        driver = new FirefoxDriver();
                        Drivers.Add("Firefox", Driver);
                    }
                    break;
            }
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public static void LoadUrl (string url)
        {
            Driver.Url = url;
        }

        public static void CloseAllDrivers()
        {
            driver.Close();
            driver.Quit();
        }

        
    }
}
