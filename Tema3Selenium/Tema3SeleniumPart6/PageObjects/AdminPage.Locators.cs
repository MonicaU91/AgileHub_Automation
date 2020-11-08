using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Tema3SeleniumPart6.PageObjects
{
    partial class AdminPage
    {
        private IWebElement AdministareButton => _driver.FindElement(By.CssSelector("a[class=nav-link][href='/product/list']"));

        public IWebElement TableAdmin => _driver.FindElement(By.CssSelector("table[class='table table-striped table-sm']"));
        public IWebElement TableUtilizatori => _driver.FindElement(By.CssSelector("table[class='table table-striped']"));
         private IWebElement UtilizatoriButton => _driver.FindElement(By.CssSelector("a[class=nav-link][href='/user/list']"));
         private IWebElement EditUtilizatorButton => _driver.FindElement(By.CssSelector("a[href='/user/edit/188']"));
        public IWebElement NumeTextField => _driver.FindElement(By.CssSelector("input[placeholder='Adaugă numele complet'][type='text']"));


    }
}
