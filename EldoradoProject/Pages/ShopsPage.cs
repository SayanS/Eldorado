using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EldoradoProject.Pages
{
    class ShopsPage:BasePage
    {
        IWebDriver webDriver;
        public ShopsPage(IWebDriver webDriver):base(webDriver)
        {
            this.webDriver = webDriver;
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
