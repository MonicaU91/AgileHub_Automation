using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace Tema3SeleniumPart6.PageObjects
{
    partial class LoginPage

    {
        private IWebElement EmailFieldTextBox => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("input[type=email]")));
        private IWebElement PasswordFieldTextBox => _driver.FindElement(By.CssSelector("input[type=password]"));

        private IWebElement SubmitButton => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("button[type=submit]")));
    }
}
