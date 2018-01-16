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
        private readonly ShopsPage shopsPage;
        public ShopsPageSteps(ShopsPage shopsPage)
        {
            this.shopsPage = shopsPage;
        }
        public void isShopsPageTitle(String title)
        {            
            Assert.AreEqual(title,shopsPage.getTitle());
        }
    }
}
