using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EldoradoProject.Pages
{
    class SelectSityFromTheListPopUp
    {
        IWebDriver webDriver;
        public SelectSityFromTheListPopUp(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
            PageFactory.InitElements(this.webDriver, this);
        }
        [FindsBy(How = How.XPath, Using = ".//div[@class='rodal-dialog city-select-container']")]
        private IWebElement container;

        [FindsBy(How = How.XPath, Using = "//div[@class='rodal-dialog ']/span[@class='rodal-close']")]
        private IWebElement closePopUpButton;
        
        public void closePopUp()
        {
            closePopUpButton.Click();
        }
    }
}
