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

    public class CRM : LandingPage
    {
        public CRM(string browser) : base(browser) { }

        public void GoToCRMHomePage()
        {
            Task.Delay(3000).Wait();
            var wait = new WebDriverWait(webDriver, TimeSpan.FromMilliseconds(10000));
            var clickableElement = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[contains(text(),'KraftCRM')]")));
            clickableElement.Click();
        }

        public void GoToCRMCompanyTab()
        {

            var wait = new WebDriverWait(webDriver, TimeSpan.FromMilliseconds(10000));
            var clickableElement = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[contains(text(),'Companies:')]")));
            clickableElement.Click();
        }

        public void CRMCreateCompany()
        {
            webDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            var wait = new WebDriverWait(webDriver, TimeSpan.FromMilliseconds(5000));
            var clickableElement = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[@class='bk-box-create bk-innerer-box-width']")));
            clickableElement.Click();
            IWebElement name = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@placeholder='Enter the name of the company']")));
            name.SendKeys("Company1");
            webDriver.FindElement(By.XPath("//*[contains(text(),'Save')]")).Click();
        }

        public void GoToCRM_PeopleTab()
        {
            var wait = new WebDriverWait(webDriver, TimeSpan.FromMilliseconds(5000));
            var clickableElement = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//a[contains(text(),'People')]")));
            clickableElement.Click();
        }

        public void CRM_CreatePerson()
        {
            var wait = new WebDriverWait(webDriver, TimeSpan.FromMilliseconds(5000));
            var clickableElement = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[@class='bk-people-container full-height']//div//span[@class='bk-box-create-icon'][contains(text(),'+')]")));
            clickableElement.Click();
            IWebElement FirstName = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@placeholder='Enter the first name of your contact']")));
            IWebElement LastName = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@placeholder='Enter the last name of your contact']")));
            FirstName.SendKeys("Person1");
            LastName.SendKeys("Person1");
            webDriver.FindElement(By.XPath("//*[contains(text(),'Save')]")).Click();
        }

        public void GoTo_Reminders()
        {
            Task.Delay(3000).Wait();
            var wait = new WebDriverWait(webDriver, TimeSpan.FromMilliseconds(5000));
            var clickableElement = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//a[contains(text(),'Reminders')]")));
            clickableElement.Click();

        }

        public void CRM_CreateReminder()
        {
            var wait = new WebDriverWait(webDriver, TimeSpan.FromMilliseconds(5000));
            var clickableElement = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[@data-class='KCRM_RemindersMain']//span[@class='bk-box-create-icon'][contains(text(),'+')]")));
            clickableElement.Click();
            IWebElement description = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@placeholder='Enter your text']")));
            description.SendKeys("My new Reminder");
            webDriver.FindElement(By.XPath("//*[contains(text(),'Save')]")).Click();

        }

        
    }
}






