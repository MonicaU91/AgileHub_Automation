using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Tema3SeleniumPart2.PageObjects
{
    partial class AutomationPracticeForm
    {
        private IWebElement NameTextBox => _driver.FindElement(By.CssSelector("input[id=firstName]"));
        private IWebElement LastNameTextBox => _driver.FindElement(By.CssSelector("input[id=lastName]"));
        private IWebElement EmailTextBox => _driver.FindElement(By.CssSelector("input[id=userEmail]"));
        private IWebElement GenderRadioButton => _driver.FindElement(By.CssSelector("label[class=custom-control-label]"));
        private IWebElement MobileNumberTextBox => _driver.FindElement(By.CssSelector("input[id=userNumber]"));
        private IWebElement DateOfBirthCalendar => _driver.FindElement(By.CssSelector("input[id=dateOfBirthInput]"));
        private IWebElement SelectYearCalendar => _driver.FindElement(By.CssSelector("select[class=react-datepicker__year-select]"));
        private IWebElement SelectMonthCalendar => _driver.FindElement(By.CssSelector("select[class=react-datepicker__month-select]"));
        private IWebElement SelectDayCalendar => _driver.FindElement(By.CssSelector("select[class=react-datepicker__week.react-datepicker__day--004]"));
        //private IWebElement SelectDayCalendar => _driver.FindElement(By.CssSelector("div[class=react-datepicker__day--004]"));
       // private IWebElement SelectDayCalendar => _driver.FindElement(By.LinkText("4"));
        private IWebElement SubjectTextBox => _driver.FindElement(By.CssSelector("input[id=subjectsInput]"));
        //private IWebElement HobbiesTextBox => _driver.FindElement(By.CssSelector("input[id=hobbies-checkbox-2]"));
        private IWebElement HobbiesTextBox => _driver.FindElement(By.LinkText("Reading"));
        private IWebElement AddressTextBox => _driver.FindElement(By.CssSelector("textarea[id=currentAddress]"));
        private IWebElement StateDropDown => _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("svg[class=css-19bqh2r]")));
        private IWebElement CityDropDown => _driver.FindElement(By.XPath("//div[class()=' css-14jk2my-container']"));
        private IWebElement SubmitButton => _driver.FindElement(By.CssSelector("button[id=submit]"));
        public IWebElement CloseButton => _driver.FindElement(By.CssSelector("button[id=closeLargeModal]"));


    }
}
