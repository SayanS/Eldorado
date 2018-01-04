using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace EldoradoProject.Pages
{
    class PageProvider
    {
        private static IWebDriver swebDriver;

        private static BasePage currentPage;
        public static void initialize(IWebDriver webDriver)
        {
            swebDriver = webDriver;
        }

        public static HomePage getHomePage()
        {
            swebDriver.Navigate().GoToUrl("https://eldorado.ua/");
            currentPage= new HomePage(swebDriver);
            return (HomePage)currentPage;
        }

        public static BasePage getCurrentPage()
        {
            return currentPage;
        }
        public static void setCurrentPage(BasePage page)
        {
            currentPage = page;
        }

    }
}
