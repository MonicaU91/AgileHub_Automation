using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Tema3SeleniumPart4
{
    public class Hooks
    {
        protected IWebDriver Driver;
        [SetUp]

        public void SetUp()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("https://www.teatrulsicaalexandrescu.ro/?lang=en");
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
