using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;


namespace Tema3SeleniumPart6.PageObjects
{
    partial class MenuPage
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;
        public MenuPage(IWebDriver driver)
        {
            _driver = driver;
            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            _driverWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
        }
        public void ClickOnLaptopuriMenu()
        {
            LaptopuriButton.Click();
        }
      
        public void ClickOnFotoMenu()
        {
            FotoButton.Click();
        
        }
        public void ClickOnCartiMenu()
        {
            CartiButton.Click();
        }
        public void ClickOnAccesoriiMenu()
        {
            AccesoriiButton.Click();
        }
    
    }
   
}
