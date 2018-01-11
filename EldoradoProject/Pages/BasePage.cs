using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace EldoradoProject.Pages
{
    [Binding]
    public class BasePage
    {
        private IWebDriver webDriver;
        public String PAGE_URL;
        public WebDriverWait wait;

        public BasePage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
            wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(5));
            PageFactory.InitElements(this.webDriver, this);
        }

        [FindsBy(How = How.XPath, Using = "//ul[@class='header-navigation']")]
        private IWebElement headerNavigationMenu;

        public IWebElement HeaderNavigationMenu { get => headerNavigationMenu; set => headerNavigationMenu = value; }

        public void scrollIntoView(IWebElement webElement, int offsetY)
        {
            int y = webElement.Location.Y + offsetY;
            ((IJavaScriptExecutor)webDriver).ExecuteScript("window.scrollTo(0," + y + ")");
        }

        public BasePage clickOnHeaderMenuItem(String itemName)
        {
            scrollIntoView(HeaderNavigationMenu.FindElement(By.XPath("//li//*[contains(text(),'" + itemName + "')]")), -100);
            HeaderNavigationMenu.FindElement(By.XPath("//li//*[contains(text(),'" + itemName + "')]")).Click();
            switch (itemName)
            {
                case "Магазины":
                   // PageProvider.setCurrentPage(new ShopsPage(webDriver));
                    return new ShopsPage(webDriver);
                default: return this;

            }

        }
    }
}
