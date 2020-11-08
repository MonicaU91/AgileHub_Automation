using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;


namespace Tema3SeleniumPart2.PageObjects
{
    partial class AutomationPracticeForm
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;

        public AutomationPracticeForm(IWebDriver driver)
        {
            _driver = driver;
            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            _driverWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
        }

        public void CompleteForm()
        {
            NameTextBox.SendKeys("Monica");
            LastNameTextBox.SendKeys("Ursache");
            EmailTextBox.SendKeys("monica91@mailinator.com");
            GenderRadioButton.Click();
            MobileNumberTextBox.SendKeys("0040752145");
            DateOfBirthCalendar.Click();
            DateOfBirthCalendar.SendKeys(Keys.Control + "a");
            DateOfBirthCalendar.SendKeys("05-04-1991");
            DateOfBirthCalendar.SendKeys(Keys.Enter);
            SubjectTextBox.Click();
            SubjectTextBox.SendKeys("Automation");
            //HobbiesTextBox.Click();
            ((IJavaScriptExecutor)_driver).ExecuteScript("window.scrollTo(0, 400)");
            AddressTextBox.Click();
            AddressTextBox.SendKeys("21 Park Street");
            //StateDropDown.Click();
            //StateDropDown.SendKeys("NCR");
            //PickState.Click();
            // StateDropDown.SendKeys(Keys.Enter);
            //CityDropDown.Click();
            //CityDropDown.SendKeys("Delhi");
            //CityDropDown.SendKeys(Keys.Enter);


        }
        public void ClickOnSubmitButton()
        {
            SubmitButton.Click();
        }
    }
}
