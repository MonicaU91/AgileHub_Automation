using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;


namespace Tema3Selenium.PageObjects
{
    partial class GooglePage
    {
        private IWebElement GoogleFieldTextBox => _driver.FindElement(By.CssSelector("input[type=text]"));
        private IWebElement GoogleImageButton => _driver.FindElement(By.LinkText("Images"));
        private IWebElement FirstImage => _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("img[class='rg_i Q4LuWd'][alt='Paris - Wikipedia']")));
        private IWebElement BackOnImages => _driver.FindElement(By.CssSelector("polygon[class=FAnDdb]"));

        public IWebElement IAgreeButton => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.Id("introAgreeButton")));
     
       
    }
}
