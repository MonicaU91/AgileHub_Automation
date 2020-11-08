using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Tema3SeleniumPart3.PageObjects;

namespace Tema3SeleniumPart3
{
    [TestFixture]
    public class Test3 : Hooks
    {

        [Test, Category("qa form")]

        public void CompleteDemoQaForm()
        {
            //Arrange
            DemoTextBox demoTextBox = new DemoTextBox(Driver);

            //Act
            demoTextBox.CompleteForm("Monica Ursache", "monica91@mailinator.com", "Aleea Rozelor nr 3", "Strada Postei nr 19");
            demoTextBox.ClickOnSubmitBtn();

            //Assert
            var assertName = demoTextBox.ReturnNameAfterSubmit();
            assertName.Contains("Monica Ursache");

        }

    }
}
