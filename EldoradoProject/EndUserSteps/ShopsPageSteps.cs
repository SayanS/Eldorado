using EldoradoProject.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EldoradoProject.EndUserSteps
{    
   public class ShopsPageSteps
    {
        private ShopsPage shopsPage;

        public void isShopsPageTitle(String title)
        {
            shopsPage = (ShopsPage)PageProvider.getCurrentPage();
            Assert.AreEqual(title,shopsPage.getTitle());
        }
    }
}
