using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Tema3Selenium
{
    public class Hooks
    {
        protected IWebDriver Driver;
        [SetUp]

        public void SetUp()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("https://www.google.com/");
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
