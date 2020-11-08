using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Tema3SeleniumPart4.PageObject
{
    partial class Teatru
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;

        public Teatru(IWebDriver driver)
        {
            _driver = driver;
            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            _driverWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
        }
        public void ClickOnTeamButton()
        {
            TeamButton.Click();
           
        }
        public void ClickOnFirstActor()
        {
            ((IJavaScriptExecutor)_driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight - 100)");
            FirstActor.Click();
        }
        public void ClickOnFirstShow()
        {
            ((IJavaScriptExecutor)_driver).ExecuteScript("window.scrollTo(0, 600)");
            FirstSpectacol.Click();
        }

      
    }
}
