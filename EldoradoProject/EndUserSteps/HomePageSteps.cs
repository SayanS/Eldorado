using EldoradoProject.Pages;
using EldoradoProject.StepDefinitions;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace EldoradoProject.EndUserSteps
{
    [Binding]
   public class HomePageSteps
    {      
        private readonly HomePage homePage;
        public HomePageSteps(HomePage homePage)
        {
               this.homePage = homePage;
        }        
      
        public void openHomePage()
        {
            homePage.open();            
        }

        public void enterIntoGlobalSearchField(string searchText)
        {
            homePage.enterIntoGlobalSearchField(searchText);
        }

        public void closeSelectYourCityDialog()
        {
            homePage.clickOnNoButtonOfSelectCityPopUp().closePopUp();
        }

        public void isDisplayedGlobalSearchAutosuggestList()
        {
            Assert.True(homePage.isDisplayedGlobalSearchAutosuggestList());
        }

        public void clickOnItemOfHeaderNavigationMenu(string itemName)
        {
           homePage.clickOnHeaderMenuItem(itemName);
        }
    }
}
