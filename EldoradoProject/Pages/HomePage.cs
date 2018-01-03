using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Firefox;

namespace EldoradoProject.Pages
{
    class HomePage:BasePage
    {
        private IWebDriver webDriver;

        public HomePage(IWebDriver webDriver):base(webDriver)
        {            
            this.webDriver = webDriver;
        }

        [FindsBy(How=How.XPath, Using = ".//div[@class='header-content desktop-header']//div[@class='select-city-content']//div[@class='button fail']")]
        private IWebElement selectCityPopUpNoButton;
        public HomePage openHomePage()
        {
            webDriver.Navigate().GoToUrl("https://eldorado.ua/");
            return new HomePage(webDriver);
        }
        public SelectSityFromTheListPopUp clickOnNoButtonOfSelectCityPopUp()
        {
            selectCityPopUpNoButton.Click();
            return new SelectSityFromTheListPopUp(webDriver);
        }
    }
}
