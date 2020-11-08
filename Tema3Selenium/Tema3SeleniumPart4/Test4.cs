using NUnit.Framework;
using Tema3SeleniumPart4.PageObject;

namespace Tema3SeleniumPart4
{
    [TestFixture]
    class Test4 : Hooks
    {

        [Test]
        public void TestTeatru()
        {
            //Arange
            Teatru teatru = new Teatru(Driver);

            //Act
            teatru.ClickOnTeamButton();
            teatru.ClickOnFirstActor();
            teatru.ClickOnFirstShow();

            //Assert
            Assert.IsTrue(teatru.CumparaBiletPrinsInPlasaButton.Displayed);
        }
    }
}
