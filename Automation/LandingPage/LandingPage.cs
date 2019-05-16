
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
using Automation;




namespace Automation
{
    public class LandingPage : EntryPoint
    {
        public LandingPage (string browser)
        {
            base.browser = browser;
        }
        public void OpenMenuButton() {
            Task.Delay(3000).Wait();
            var wait = new WebDriverWait(webDriver, TimeSpan.FromMilliseconds(10000));
            var clickableElement = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/*")));
            clickableElement.Click();
        }
        [Test]
        public void OpenBindKraft()
        {
            webDriver.Url = "https://www.bindkraft.com/en/";
            webDriver.FindElement(By.XPath("//a[contains(text(),'Get Started')]")).Click();
            Assert.IsTrue(webDriver.PageSource.Contains("Email"));
            
        }
        [Test]
        public void LoginBK()
        {
            var wait = new WebDriverWait(webDriver, TimeSpan.FromMilliseconds(5000));
            IWebElement email = webDriver.FindElement(By.Id("Email"));
            IWebElement password = webDriver.FindElement(By.Id("Password"));
            email.SendKeys("drake@abv.bg");
            password.SendKeys("Dsa_123");
            var clickableElement = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[@class='bk-button bk-button-block bk-margin-bottom-1']")));
            clickableElement.Click();
            webDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            //Assert.IsTrue(webDriver.PageSource.Contains("dasdasd"));
            //Assert.Fail("LoginBK step");
         }
        [Test]
        public void ProfileMenu()
        {

            var wait = new WebDriverWait(webDriver, TimeSpan.FromMilliseconds(5000));
            var clickableElement = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[contains(@id,'Layer_1')]")));
            clickableElement.Click();
        }
        public void DisableNotification()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--disable-extensions");
            options.AddArguments("--disable-notifications");
            options.AddArguments("--disable-application-cache");
            webDriver = new ChromeDriver(options);

        }
        // TODO : example
        public void TestWithChromeDriver()
        {
            using (var driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)))
            {
                driver.Navigate().GoToUrl(@"https://www.bindkraft.com/en/");
                var link = driver.FindElement(By.PartialLinkText("Get Started"));
                var jsToBeExecuted = $"window.scroll(0, {link.Location.Y});";
                ((IJavaScriptExecutor)driver).ExecuteScript(jsToBeExecuted);
                var wait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
                var clickableElement = wait.Until(ExpectedConditions.ElementToBeClickable(By.PartialLinkText("Get Started")));
                clickableElement.Click();

                
            }
        }
        [FindsBy(How = How.XPath, Using = "pwd")]
        public IWebElement Password { get; set; }
        
    }
}
