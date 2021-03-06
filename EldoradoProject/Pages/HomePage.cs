﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using EldoradoProject.StepDefinitions;

namespace EldoradoProject.Pages
{
    [Binding]
    public class HomePage : BasePage
    {
        private readonly Browser browser;
        private readonly IWebDriver webDriver;

        public HomePage(Browser browser) : base(browser)
        {
            this.browser = browser;
            this.webDriver = browser.webDriver;
            this.PAGE_URL = "https://eldorado.ua/";
        }
        
        public void open()
        {
            webDriver.Navigate().GoToUrl("https://eldorado.ua/");
        }

        [FindsBy(How = How.XPath, Using = ".//div[@class='header-content desktop-header']//div[@class='select-city-content']//div[@class='button fail']")]
        private IWebElement selectCityPopUpNoButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='header-content desktop-header']//input[@class='react-autosuggest__input']")]
        private IWebElement globalSearchField { get; set; }

        private By GLOBAL_SEARCH_AUTOSUGGEST_FIELD = By.XPath(".//ul[@class='react-autosuggest__suggestions-list']");


        public void enterIntoGlobalSearchField(string searchText)
        {
            globalSearchField.Clear();
            globalSearchField.SendKeys(searchText);           
        }

        public bool isDisplayedGlobalSearchAutosuggestList()
        {
            try
            {
                wait.Until(ExpectedConditions.ElementIsVisible(GLOBAL_SEARCH_AUTOSUGGEST_FIELD));
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public SelectSityFromTheListPopUp clickOnNoButtonOfSelectCityPopUp()
        {
            selectCityPopUpNoButton.Click();
            return new SelectSityFromTheListPopUp(browser);
        }
    }
}
