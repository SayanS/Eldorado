using BoDi;
using EldoradoProject.EndUserSteps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace EldoradoProject.StepDefinitions
{
    [Binding]
   public class ShopStepsDefinitions
    {
       private HomePageSteps homePageSteps;
        private SelectSityFromTheListPopUpSteps selectSityFromTheListPopUpSteps;
        private ShopsPageSteps shopsPageSteps;
 
         public ShopStepsDefinitions(HomePageSteps homePageSteps,
                               SelectSityFromTheListPopUpSteps selectSityFromTheListPopUpSteps,
                               ShopsPageSteps shopsPageSteps 
                          )
        { 
            this.homePageSteps = homePageSteps;
            this.selectSityFromTheListPopUpSteps = selectSityFromTheListPopUpSteps;
            this.shopsPageSteps = shopsPageSteps;            
        }
        
        [Given(@"New methodl")]
        public void GivenNewMethodl()
        {
            int i = 0;
            homePageSteps.enterIntoGlobalSearchField(homePageSteps.currentSearchText+"EEEEEEEEEEEEEEEE");

        }

    }
}
