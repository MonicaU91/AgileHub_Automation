using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Tema3SeleniumPart6
{
    public class Hooks
    {
        protected IWebDriver Driver;
        [SetUp]

        public void SetUp()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("http://demosite.casqad.org/");
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
