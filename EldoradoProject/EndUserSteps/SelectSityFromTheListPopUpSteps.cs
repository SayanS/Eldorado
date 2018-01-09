using EldoradoProject.Pages;
using EldoradoProject.StepDefinitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EldoradoProject.EndUserSteps
{
   public class SelectSityFromTheListPopUpSteps
    {
        SelectSityFromTheListPopUp selectSityFromTheListPopUp;
        public void closeSelectYourCityDialog()
        {
            selectSityFromTheListPopUp.closePopUp();
        }
    }
}
