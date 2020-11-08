using NUnit.Framework;
using Tema3SeleniumPart6.PageObjects;

namespace Tema3SeleniumPart6
{
    [TestFixture]
    public class Test6 : Hooks
    {
        [Test, Category("Login")]
        public void ValidateLoginIntoApp()

        { //Arrange
            HomePage homePage = new HomePage(Driver);
            homePage.GoToAuthentication();

            //Act
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.AuthenticateUser("monicaursache91@mailinator.com", "bubu2020");

            //Assert
            Assert.IsTrue(homePage.DeconectareButton.Displayed);
        }
        [Test, Category("Add a product to cart as a user")]
        public void ValidateAddAProductAsAUser()
        {
            //Arrange
            HomePage homePage = new HomePage(Driver);
            homePage.GoToAuthentication();

            //Act
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.AuthenticateUser("monicaursache91@mailinator.com", "bubu2020");
            ProductsPage productsPage = new ProductsPage(Driver);
            productsPage.AddAProductToCart();

            //Assert
            Assert.IsTrue(productsPage.ComandaAcumBtn.Displayed);
        }
        [Test, Category("Add a product to cart as a admin")]
        public void ValidateAddAProductAsAdmin()
        {
            //Arrange
            HomePage homePage = new HomePage(Driver);
            homePage.GoToAuthentication();

            //Act
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.AuthenticateUser("admin.test3@gmail.com", "password123");
            ProductsPage productsPage = new ProductsPage(Driver);
            productsPage.AddAProductToCart();

            //Assert
            Assert.IsTrue(productsPage.ComandaAcumBtn.Displayed);
        }
        [Test, Category("Inscriere si logare")]
        public void ValidateInscriereSiLogare()
        {

            //Arrange
            HomePage homePage = new HomePage(Driver);

            //Act
            homePage.InscriereButton.Click();
            homePage.ValidateInscriere("Monica U", "test20@mailinator.com", "postei 19", "password2020", "password2020");
            homePage.ClickOnSubmitBtn();
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.AuthenticateUser("test20@mailinator.com", "password2020");

            //Assert
            Assert.IsTrue(homePage.DeconectareButton.Displayed);
        }
        [Test, Category("logare si delogare")]
        public void ValidateLoginAndDisconnect()
        {
            //Arrange
            LoginPage loginPage = new LoginPage(Driver);
            HomePage homePage = new HomePage(Driver);
            //Act
            homePage.GoToAuthentication();
            loginPage.AuthenticateUser("monicaursache91@mailinator.com", "bubu2020");
            homePage.DeconectareButton.Click();

            //Assert
            Assert.IsTrue(homePage.InscriereButton.Displayed);

        }
        [Test, Category("Validate all menu buttons")]
        public void ValidateAllMeniuButtons()
        {

            //Arrange
            LoginPage loginPage = new LoginPage(Driver);
            HomePage homePage = new HomePage(Driver);
            MenuPage menuPage = new MenuPage(Driver);
            ProductsPage productsPage = new ProductsPage(Driver);

            //Act
            homePage.GoToAuthentication();
            loginPage.AuthenticateUser("monicaursache91@mailinator.com", "bubu2020");
            menuPage.ClickOnLaptopuriMenu();
            productsPage.TelefoaneButton.Click();
            menuPage.ClickOnFotoMenu();
            menuPage.ClickOnCartiMenu();
            menuPage.ClickOnAccesoriiMenu();
            //Assert
            Assert.IsTrue(menuPage.VeziDetaliiRucsacLaptopTrustLimaBtn.Displayed);

        }
        [Test, Category("Validate administare buttons")]
        public void ValidateAdministareMenu()
        {
            //Arrange
            LoginPage loginPage = new LoginPage(Driver);
            HomePage homePage = new HomePage(Driver);
            AdminPage adminPage = new AdminPage(Driver);

            //Act
            homePage.GoToAuthentication();
            loginPage.AuthenticateUser("admin.test3@gmail.com", "password123");
            adminPage.ClickOnAdministareMenu();

            //Assert
            Assert.IsTrue(adminPage.TableAdmin.Displayed);
        }
        [Test, Category("Validate utilizatori buttons")]
        public void ValidateUtilizatoriMenu()
        {
            //Arrange
            LoginPage loginPage = new LoginPage(Driver);
            HomePage homePage = new HomePage(Driver);
            AdminPage adminPage = new AdminPage(Driver);

            //Act
            homePage.GoToAuthentication();
            loginPage.AuthenticateUser("admin.test3@gmail.com", "password123");
            adminPage.ClickOnAdministareMenu();
            adminPage.ClickOnUtilizatoriMenu();

            //Assert
            Assert.IsTrue(adminPage.TableUtilizatori.Displayed);
        }
        [Test, Category("Validate utilizatori edit")]
        public void ValidateEditUtilizator()
        {

            //Arrange
            LoginPage loginPage = new LoginPage(Driver);
            HomePage homePage = new HomePage(Driver);
            AdminPage adminPage = new AdminPage(Driver);

            //Act
            homePage.GoToAuthentication();
            loginPage.AuthenticateUser("admin.test3@gmail.com", "password123");
            adminPage.ClickOnAdministareMenu();
            adminPage.ClickOnUtilizatoriMenu();
            adminPage.ClickOnEditButton();
            adminPage.EditNumeUtilizator();
            homePage.ClickOnSubmitBtn();

            //Assert
            adminPage.ClickOnUtilizatoriMenu();
            adminPage.ClickOnEditButton();
            var numeUtilizator188 = adminPage.ReturnNumeUtilizator();
            numeUtilizator188.Equals("Monica EditTest");

        }
    }
}
