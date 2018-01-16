using EldoradoProject.EndUserSteps;
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
         public ShopPageSteps(HomePageSteps homePageSteps)
         {
            this.homePageSteps = homePageSteps;
         }
        private HomePageSteps homePageSteps;
    
        [Given(@"New method")]
        public void GivenNewMethod()
        {
            homePageSteps.enterIntoGlobalSearchField("My text");           
        }


    }
}
