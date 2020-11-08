using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;


namespace Tema3SeleniumPart3.PageObjects
{
    partial class DemoTextBox
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;

        public DemoTextBox(IWebDriver driver)
        {
            _driver = driver;
            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            _driverWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
        }
        public void CompleteForm(string name, string email, string currentAddress, string permanentAddress)
        {
            FullNameTextBox.SendKeys(name);
            EmailTextBox.SendKeys(email);
            CurrentAddressTextBox.SendKeys(currentAddress);
            PermanentAddressTextBox.SendKeys(permanentAddress);
          
        }
        public void ClickOnSubmitBtn()
        { 
             ((IJavaScriptExecutor)_driver).ExecuteScript("window.scrollTo(0, 400)");
              SubmitButton.Click();
        }
        public string ReturnNameAfterSubmit()
        {
            return NameTextBox.Text;
        }
    }
}
