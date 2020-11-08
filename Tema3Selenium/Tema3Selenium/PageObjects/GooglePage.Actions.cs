using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;


namespace Tema3Selenium.PageObjects
{
    partial class GooglePage
    {

        private IWebDriver _driver;
        private WebDriverWait _driverWait;

        public GooglePage(IWebDriver driver)
        {
            _driver = driver;
            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            _driverWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
        }


        public void AgreeGooglePopUp()
        { 
         IAgreeButton.Click();
        }

        public void SelectAImageWithParis(string imageName)
        {
            GoogleFieldTextBox.Click();
            GoogleFieldTextBox.SendKeys(imageName);
            GoogleFieldTextBox.SendKeys(Keys.Enter);

        }
        public void ClickOnImages()
        {
            GoogleImageButton.Click();
        }
        public void ClickOnFirstImage()
        {
            FirstImage.Click();
        }

        public void ClickBackOnImages()
        {
            BackOnImages.Click();
        }
        public bool AssertMethod()
        { 
            var assert = _driverWait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.CssSelector("a[jsname='tqp7ud'][class='hm60ue']")));
            return assert;
        }



    }
}
