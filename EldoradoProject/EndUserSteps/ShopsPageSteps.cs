using EldoradoProject.Pages;
using EldoradoProject.StepDefinitions;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EldoradoProject.EndUserSteps
{    
   public class ShopsPageSteps
    {        
        public ShopsPageSteps(Browser browser)
        {
            shopsPage = new ShopsPage(browser);
        }
        private ShopsPage shopsPage;           

        public void isShopsPageTitle(String title)
        {            
            Assert.AreEqual(title,shopsPage.getTitle());
        }
    }
}
