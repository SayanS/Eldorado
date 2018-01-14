using EldoradoProject.StepDefinitions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace EldoradoProject.Pages
{
    [Binding]
    public class ShopsPage:BasePage
    {
        private readonly Browser browser;
        private readonly IWebDriver webDriver;
        public ShopsPage(Browser browser):base(browser)
        {
            this.browser = browser;
            this.webDriver = browser.webDriver;
        }

        [FindsBy(How = How.XPath, Using = "//div[@class='shops-title']")]
        private IWebElement title { get; set; }

        public String getTitle()
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementExists(By.XPath("//div[@class='shops-title']")));
            return title.Text;
        }

    }
}
