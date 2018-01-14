using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using EldoradoProject.Pages;
using NUnit.Framework;
using EldoradoProject.EndUserSteps;

namespace EldoradoProject.StepDefinitions
{
    [Binding]
    public class StepDefinitions
    {
        private HomePageSteps homePageSteps;
        private SelectSityFromTheListPopUpSteps selectSityFromTheListPopUpSteps;
        private ShopsPageSteps shopsPageSteps;       

        public StepDefinitions(Browser browser)
        {
            homePageSteps = new HomePageSteps(browser);
            selectSityFromTheListPopUpSteps = new SelectSityFromTheListPopUpSteps(browser);
            shopsPageSteps = new ShopsPageSteps(browser);
        }

        [Given(@"Homepage is opened")]
        public void GivenHomepageIsOpened()
        {            
            homePageSteps.openHomePage();
        }
        
        [Given(@"Close Select your city dialog")]
        public void GivenCloseSelectYourCityDialog()
        {
            homePageSteps.closeSelectYourCityDialog();
        }

        [Given(@"Enter ""(.*)"" into Global Search field")]
        public void GivenEnterIntoGlobalSearchField(string searchText)
        {
            homePageSteps.enterIntoGlobalSearchField(searchText);            
        }

        [Then(@"Global Search Autosuggest list should be displayed")]
        public void ThenGlobalSearchAutosuggestListShouldBeDisplayed()
        {
            homePageSteps.isDisplayedGlobalSearchAutosuggestList();
        }

        [Then(@"All products name in Autosuggest list should contains ""(.*)""")]
        public void ThenAllProductsNameInAutosuggestListShouldContains(string searchText)
        {
            
        }

        [When(@"Click on item ""(.*)"" of Header navigation menu")]
        public void WhenClickOnItemOfHeaderNavigationMenu(string itemName)
        {
            homePageSteps.clickOnItemOfHeaderNavigationMenu(itemName);
        }

        [Then(@"Shops page should be opened with title ""(.*)""")]
        public void ThenShopsPageShouldBeOpenedWithTitle(string title)
        {
            shopsPageSteps.isShopsPageTitle(title);
        }        

    }
}
