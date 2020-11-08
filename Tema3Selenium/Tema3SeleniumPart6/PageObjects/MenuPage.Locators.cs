using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Tema3SeleniumPart6.PageObjects
{
    partial class MenuPage
    {
        private IWebElement LaptopuriButton => _driver.FindElement(By.CssSelector("a[class=nav-link][href='/category/show/1']"));
        private IWebElement FotoButton => _driver.FindElement(By.CssSelector("a[class=nav-link][href='/category/show/3']"));
        private IWebElement CartiButton => _driver.FindElement(By.CssSelector("a[class=nav-link][href='/category/show/4']"));
        private IWebElement AccesoriiButton => _driver.FindElement(By.CssSelector("a[class=nav-link][href='/category/show/5']"));

        public IWebElement VeziDetaliiRucsacLaptopTrustLimaBtn => _driver.FindElement(By.CssSelector("a[href='/product/show/40']"));


    }
}
