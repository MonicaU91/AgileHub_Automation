using NUnit.Framework;
using Tema3SeleniumPart2.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tema3SeleniumPart2
{
    [TestFixture]
    public class Test2 : Hooks
    {

        [Test, Category("Form")]
        public void CompleteAutomationPracticeForm()
        {
            //Arrange
            AutomationPracticeForm automationPage = new AutomationPracticeForm(Driver);

            //Act
            automationPage.CompleteForm();
            automationPage.ClickOnSubmitButton();


            //Assert
            NUnit.Framework.Assert.IsTrue(automationPage.CloseButton.Displayed);
        }
    }
}
