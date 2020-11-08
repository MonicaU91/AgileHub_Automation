using NUnit.Framework;
using Tema3Selenium.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace Tema3Selenium
{
    [TestFixture]
    class Test1 : Hooks
    {
        [Test, Category("GoogleImage")]

        public void TestMethod1()
        {
            //Arrange
            GooglePage googlePage = new GooglePage(Driver);
            Thread.Sleep(1000);

            //Act
            // googlePage.AgreeGooglePopUp();
            googlePage.SelectAImageWithParis("Paris");
            googlePage.ClickOnImages();
            googlePage.ClickOnFirstImage();
            googlePage.ClickBackOnImages();

            //Assert 
            var assert1 = googlePage.AssertMethod();
            assert1.Equals(true);


        }

    }
}
