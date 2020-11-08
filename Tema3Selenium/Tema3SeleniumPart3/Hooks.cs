using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Tema3SeleniumPart3
{
    public class Hooks
    {
        protected IWebDriver Driver;
        [SetUp]

        public void SetUp()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("https://demoqa.com/text-box");
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
