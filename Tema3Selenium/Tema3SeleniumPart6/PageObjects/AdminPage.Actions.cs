using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;


namespace Tema3SeleniumPart6.PageObjects
{
    partial class AdminPage
    {

        private IWebDriver _driver;
        private WebDriverWait _driverWait;
        public AdminPage(IWebDriver driver)
        {
            _driver = driver;
            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            _driverWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
        }
        public void ClickOnAdministareMenu()
        {
            AdministareButton.Click();

        }
        public void ClickOnUtilizatoriMenu()
        {
            UtilizatoriButton.Click();
        }
        public void ClickOnEditButton()
        {
            EditUtilizatorButton.Click();
        }
        public void EditNumeUtilizator()
        {
            NumeTextField.Click();
            NumeTextField.SendKeys(Keys.Control + "a");
            NumeTextField.SendKeys("Monica EditTest");
        }
        public string ReturnNumeUtilizator()
        {
            return NumeTextField.Text;
        }
    }
}
