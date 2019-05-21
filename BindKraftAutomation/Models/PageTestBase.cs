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

        internal void InitDriver(string url = Constants.BINDKRAFT_URL)
        {
            this.driver = new ChromeDriver(Constants.chromeDriverPath);
            this.driver.Url = url;
            this.homePage = new LandingPage(this.driver);
        }

    }
}
