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

namespace EldoradoProject.EndUserSteps
{
    class HomePageSteps
    {
        HomePage homePage;
        public void openHomePage()
        {
            homePage = PageProvider.getHomePage();            
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
