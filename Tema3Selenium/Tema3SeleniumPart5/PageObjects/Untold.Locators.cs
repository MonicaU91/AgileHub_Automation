using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;



namespace Tema3SeleniumPart5.PageObject
{
    partial class Untold
    {
        private IWebElement MenuButton => _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("div[class=bm-burger-button]")));
        private IWebElement HomeButton => _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("a[class=styles-module--menuItem--2roYz]")));
        public IWebElement SocialMediaButtons => _driver.FindElement(By.CssSelector("div[class='styles-module--socialsWrapper--3iyo4']"));

    }
}
