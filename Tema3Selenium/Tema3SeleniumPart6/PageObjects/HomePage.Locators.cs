using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Tema3SeleniumPart6.PageObjects
{
     
    partial class HomePage
    {
       
        private IWebElement AutentificationButton => _driver.FindElement(By.XPath("//a[text()='Autentificare']"));
        public IWebElement DeconectareButton => _driver.FindElement(By.XPath("//a[text()='Deconectare']"));

        public IWebElement InscriereButton => _driver.FindElement(By.XPath("//a[text()='Înscriere']"));
        private IWebElement NumeTextField => _driver.FindElement(By.CssSelector("input[placeholder='Adaugă numele complet'][type='text']"));
        private IWebElement EmailTextField => _driver.FindElement(By.CssSelector("input[placeholder='Adaugă adresa de email'][type='email']"));
        private IWebElement TelefonTextField => _driver.FindElement(By.CssSelector("input[placeholder='Adaugă numarul de telefon'][name='phone']"));
        private IWebElement AdresaTextField => _driver.FindElement(By.CssSelector("textarea[placeholder='Adaugă adresa'][name='address']"));
        private IWebElement ParolaTextField => _driver.FindElement(By.CssSelector("input[placeholder='Adaugă parola'][name='password_1']"));
        private IWebElement RepetaParolaTextField => _driver.FindElement(By.CssSelector("input[placeholder='Repetă parola'][name='password_2']"));
        private IWebElement SubmitBtn => _driver.FindElement(By.CssSelector("button[type='submit'][class='btn btn-primary']"));



    }
}
