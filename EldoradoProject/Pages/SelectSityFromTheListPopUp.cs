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
    public class SelectSityFromTheListPopUp:BasePage
    {
        private readonly Browser browser;
        private readonly IWebDriver webDriver;
        public SelectSityFromTheListPopUp(Browser browser):base(browser)
        {
            this.browser = browser;
            this.webDriver = browser.webDriver;            
        }
        
        [FindsBy(How = How.XPath, Using = ".//div[@class='rodal-dialog city-select-container']")]
        private IWebElement container;

        [FindsBy(How = How.XPath, Using = "//div[@class='rodal-dialog city-select-container']/span[@class='rodal-close']")]
        private IWebElement closePopUpButton;

        public IWebElement ClosePopUpButton { get => closePopUpButton; set => closePopUpButton = value; }
        public IWebElement Container { get => container; set => container = value; }

        public void closePopUp()
        {            
            ClosePopUpButton.Click();
        }
    }
}
