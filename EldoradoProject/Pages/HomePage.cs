using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

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
        private IWebElement selectCityPopUpNoButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='header-content desktop-header']//input[@class='react-autosuggest__input']")]
        private IWebElement globalSearchField { get; set; }
                
        private String GLOBAL_SEARCH_AUTOSUGGEST_FIELD = ".//ul[@class='react-autosuggest__suggestions-list']";
        private object driver;

        public void enterIntoGlobalSearchField(string searchText)
        {
            globalSearchField.Clear();
            globalSearchField.SendKeys(searchText);
        }

        public bool isDisplayedGlobalSearchAutosuggestList()
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(5));
                wait.Until(ExpectedConditions.ElementExists(By.XPath(GLOBAL_SEARCH_AUTOSUGGEST_FIELD)));
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public SelectSityFromTheListPopUp clickOnNoButtonOfSelectCityPopUp()
        {
            selectCityPopUpNoButton.Click();
            return new SelectSityFromTheListPopUp(webDriver);
        }
    }
}
