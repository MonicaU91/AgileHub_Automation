using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;


namespace Tema3SeleniumPart5.PageObject
{
    partial class Untold
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;

        public Untold(IWebDriver driver)
        {
            _driver = driver;
            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            _driverWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
        }

        public void ClickOnMenuBtn()
        {
            MenuButton.Click();
           
            
        }
        public void ClickOnHomeBtn()
        {
           
            HomeButton.Click();

        }
    }
}
