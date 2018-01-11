using BoDi;
using EldoradoProject.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace EldoradoProject.StepDefinitions
{
    [Binding]
    public class Hooks
    {
        private readonly IObjectContainer objectContainer;
        private IWebDriver webDriver;

        public Hooks(IObjectContainer objectContainer)
        {
            this.objectContainer = objectContainer;
        }

        [BeforeScenario]
        public void setUp() {            
            FirefoxDriverService ffService = FirefoxDriverService.CreateDefaultService(@"..\packages\WebDriver.GeckoDriver.0.19.0\content");
            webDriver = new FirefoxDriver(ffService);
            webDriver.Manage().Window.Maximize();
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            objectContainer.RegisterInstanceAs<IWebDriver>(webDriver);
            //PageProvider.initialize(webDriver);
        }
        [AfterScenario]
        public void tearDown()
        {
            webDriver.Quit();
        }

    }
}
