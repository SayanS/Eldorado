using EldoradoProject.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EldoradoProject.EndUserSteps
{
    class HomePageSteps
    {
        private HomePage homePage;

        public HomePageSteps()
        {
            IWebDriver webDriver; 
            FirefoxDriverService ffService = FirefoxDriverService.CreateDefaultService(@"..\packages\WebDriver.GeckoDriver.0.19.0\content");
            webDriver = new FirefoxDriver(ffService);
            webDriver.Manage().Window.Maximize();
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            homePage = new HomePage(webDriver);
        }
        public void openHomePage()
        {
            homePage=homePage.openHomePage();
        }
    }
}
