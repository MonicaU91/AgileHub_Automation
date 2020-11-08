using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema3SeleniumPart6.PageObjects
{
    partial class HomePage
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;
        public HomePage(IWebDriver driver)
        {
            _driver = driver;
            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            _driverWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
        }
        public void GoToAuthentication()
        {
            AutentificationButton.Click();
        }
        public void ValidateInscriere(string nume, string email, string adresa, string parola, string repetaParola)
        {
            NumeTextField.Click();
            NumeTextField.SendKeys(nume);
            EmailTextField.Click();
            EmailTextField.SendKeys(email);
            TelefonTextField.Click();
            TelefonTextField.SendKeys("0757638899");
            AdresaTextField.Click();
            AdresaTextField.SendKeys(adresa);
            ParolaTextField.Click();
            ParolaTextField.SendKeys(parola);
            RepetaParolaTextField.Click();
            RepetaParolaTextField.SendKeys(repetaParola);
           

        }
        public void ClickOnSubmitBtn()
        { 
         SubmitBtn.Click();
        }
    }
}
