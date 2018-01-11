using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace EldoradoProject.StepDefinitions
{
    [Binding]
    class ShopPageSteps
    {
        [Given(@"New method")]
        public void GivenNewMethod()
        {
            ScenarioContext.Current.Pending();
        }


    }
}
