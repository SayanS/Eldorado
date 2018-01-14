﻿using EldoradoProject.EndUserSteps;
using EldoradoProject.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace EldoradoProject.StepDefinitions
{
    [Binding]
    class ShopPageSteps {      
         public ShopPageSteps(Browser browser)
         {
            homePageSteps = new HomePageSteps(browser);
         }
        private HomePageSteps homePageSteps;
    
        [Given(@"New method")]
        public void GivenNewMethod()
        {
            homePageSteps.enterIntoGlobalSearchField("My text");           
        }


    }
}
