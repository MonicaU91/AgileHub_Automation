using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace Tema3SeleniumPart3.PageObjects
{
    partial class DemoTextBox
    {
        private IWebElement FullNameTextBox =>_driverWait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("input[id=userName]")));
        private IWebElement EmailTextBox => _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("input[id=userEmail]")));
        private IWebElement CurrentAddressTextBox => _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("textarea[id=currentAddress]")));
        private IWebElement PermanentAddressTextBox => _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("textarea[id=permanentAddress]")));
        private IWebElement SubmitButton => _driver.FindElement(By.CssSelector("button[id=submit]"));
        public IWebElement NameTextBox =>  _driverWait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("p[id='name'][class='mb-1']")));

    }
}
