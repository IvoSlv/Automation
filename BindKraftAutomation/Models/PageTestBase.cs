﻿using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using BindKraftAutomation.Globals;
using BindKraftAutomation.PageObject;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using System.IO;
using System.Reflection;

namespace BindKraftAutomation.Models
{
    public abstract class PageTestBase
    {
        internal IWebDriver driver;
        internal LandingPage homePage;
        internal ExtentHtmlReporter htmlReport;
        internal static ExtentReports extent = new ExtentReports();
        internal static ExtentTest test;


        internal void InitDriver(string url = Constants.BINDKRAFT_URL)
        {
            this.driver = new ChromeDriver(Constants.chromeDriverPath);
            this.driver.Url = url;
            this.homePage = new LandingPage(this.driver);
            initReporter();
        }

        public void ClickElement(IWebElement el, IWebElement close = null)
        {
            try
            {
                var clickableElement = new WebDriverWait(driver, TimeSpan.FromSeconds(3)).Until(ExpectedConditions.ElementToBeClickable(el));
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

            var rootPath = new DirectoryInfo(
                Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location))
                .Parent.Parent.Parent;
            var Date = DateTime.Now.ToString().Replace(' ', '_');
            this.htmlReport = new ExtentHtmlReporter(rootPath.FullName + "\\TestResults\\Report" + Date + ".html");
            htmlReport.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            extent.AttachReporter(htmlReport);

        }

        public void CloseAllDrivers()
        {
            this.driver.Close();
            this.driver.Dispose();
        }
    }
}
