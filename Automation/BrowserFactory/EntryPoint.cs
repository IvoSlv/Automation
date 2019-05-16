using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Threading;
using System.IO;
using System.Reflection;
using OpenQA.Selenium.Support;
using NUnit;
using OpenQA.Selenium.IE;
using System.Configuration;
using OpenQA.Selenium.Support.PageObjects;
using NUnit.Framework;

namespace Automation
{
    public abstract class EntryPoint
    {
        public string browser = ConfigurationManager.AppSettings["browser"];
        public static IWebDriver webDriver;

        public static IWebDriver Driver
        {
            get
            {
                if (webDriver == null)
                    throw new NullReferenceException("The WebDriver browser instance was not initialized. You should first call the method InitBrowser.");
                return webDriver;
            }
            
        }

        [SetUp]
        public void Init ()
        {
            switch (browser.ToLower())
            {
                case "chrome":
                    webDriver = new ChromeDriver(@"D:\_Development\ChromeDriverOld");
                    break;
                case "ie":
                        webDriver = new InternetExplorerDriver();
                    break;
                case "firefox":
                        webDriver = new FirefoxDriver();
                    break;
            }
            webDriver.Manage().Window.Maximize();
        }

        
        [TearDown]
        public void EndTest()
        {
            webDriver.Quit();
            throw new NotImplementedException();
        }




    }
}
