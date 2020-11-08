using NUnit.Framework;
using Tema3SeleniumPart5.PageObject;
using Assert = NUnit.Framework.Assert;

namespace Tema3SeleniumPart5
{
    [TestFixture]
    public class Test5 : Hooks
    {
        [Test, Category("Untold")]
        public void SelectHomePage()
        {
            //Arrange
            Untold untold = new Untold(Driver);

            //Act
            untold.ClickOnMenuBtn();
            untold.ClickOnHomeBtn();

            //Assert
            Assert.False(untold.SocialMediaButtons.Displayed);
        }
    }
}
