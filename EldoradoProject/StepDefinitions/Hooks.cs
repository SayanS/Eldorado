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
    class Hooks
    {
        private readonly Browser browser;

        public Hooks(Browser browser)
        {
            this.browser = browser;
        }

        [BeforeScenario]
        public void setUp()
        {
            FirefoxDriverService ffService = FirefoxDriverService.CreateDefaultService(@"..\packages\WebDriver.GeckoDriver.0.19.0\content");
            browser.webDriver = new FirefoxDriver(ffService);
            browser.webDriver.Manage().Window.Maximize();
            browser.webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
        [AfterScenario]
        public void tearDown()
        {
            browser.webDriver.Quit();
        }

    }
}
