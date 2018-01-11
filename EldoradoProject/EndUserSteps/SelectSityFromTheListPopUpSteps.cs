﻿using EldoradoProject.Pages;
using EldoradoProject.StepDefinitions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace EldoradoProject.EndUserSteps
{
    [Binding]
    public class SelectSityFromTheListPopUpSteps
    {
    public SelectSityFromTheListPopUpSteps(IWebDriver webDriver)
    {
        selectSityFromTheListPopUp = new SelectSityFromTheListPopUp(webDriver);
    }
        SelectSityFromTheListPopUp selectSityFromTheListPopUp;
        public void closeSelectYourCityDialog()
        {
            selectSityFromTheListPopUp.closePopUp();
        }
    }
}
