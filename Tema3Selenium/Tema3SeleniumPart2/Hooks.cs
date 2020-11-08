using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Tema3SeleniumPart2
{
    public class Hooks
    {
        protected IWebDriver Driver;
        [SetUp]

        public void SetUp()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("https://demoqa.com/automation-practice-form");
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
