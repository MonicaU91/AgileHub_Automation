using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;


namespace Tema3SeleniumPart6.PageObjects
{
    partial class ProductsPage
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;
        public ProductsPage(IWebDriver driver)
        {
            _driver = driver;
            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            _driverWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
        }
        public void AddAProductToCart()
        {
            TelefoaneButton.Click();
            HuaweiButton.Click();
            VeziDetaliiBtn.Click();
            AdaugaInCostBtn.Click();
        }
    }
}
