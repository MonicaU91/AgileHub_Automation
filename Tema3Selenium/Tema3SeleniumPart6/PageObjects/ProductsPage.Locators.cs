using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Tema3SeleniumPart6.PageObjects
{
    partial class ProductsPage

    {
        public IWebElement TelefoaneButton => _driver.FindElement(By.CssSelector("a[class=nav-link][href='/category/show/2']"));
        private IWebElement HuaweiButton => _driver.FindElement(By.CssSelector("a[href='/subcategory/show/14']"));
        private IWebElement VeziDetaliiBtn => _driver.FindElement(By.CssSelector("a[href='/product/show/22']"));
        private IWebElement AdaugaInCostBtn => _driver.FindElement(By.CssSelector("a[href='/product/addToCart/22']"));
        public IWebElement ComandaAcumBtn => _driver.FindElement(By.CssSelector("a[href='/order/store']"));



    }
}
