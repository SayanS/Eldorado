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

        public StepDefinitions()
        {
            homePageSteps = new HomePageSteps();
            selectSityFromTheListPopUpSteps = new SelectSityFromTheListPopUpSteps();
        }

        [Given(@"Homepage is opened")]
        public void GivenHomepageIsOpened()
        {            
            homePageSteps.openHomePage();
        }
        
        [Given(@"Close Select your city dialog")]
        public void GivenCloseSelectYourCityDialog()
        {
            selectSityFromTheListPopUpSteps.closeSelectYourCityDialog();
        }

        [Given(@"Enter ""(.*)"" into Global Search field")]
        public void GivenEnterIntoGlobalSearchField(string searchText)
        {
            
        }

        [Then(@"Global Search Autosuggest list should be displayed")]
        public void ThenGlobalSearchAutosuggestListShouldBeDisplayed()
        {
            
        }

        [Then(@"All products name in Autosuggest list should contains ""(.*)""")]
        public void ThenAllProductsNameInAutosuggestListShouldContains(string searchText)
        {
            
        }

    }
}
