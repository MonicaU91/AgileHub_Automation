using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;


namespace Tema3SeleniumPart4.PageObject
{
    partial class Teatru
    {
        private IWebElement TeamButton => _driver.FindElement(By.LinkText("Team"));
        private IWebElement FirstActor => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.Id("av-masonry-1-item-2697")));
        private IWebElement FirstSpectacol => _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("a[href='http://www.teatrulsicaalexandrescu.ro/prins-in-plasa/']")));
        //private IWebElement FirstSpectacol => _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("p[style='text-align: center;'].ToArray[1]")));
       // private IWebElement FirstSpectacol => _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.PartialLinkText("prins-in-plasă")));
        public IWebElement CumparaBiletPrinsInPlasaButton => _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("span[class=avia_iconbox_title]")));

    }
}
