using TallerAuto;
using TallerAuto.PageObject.LoginPage;

namespace TallerAuto.Test.LoginTest
{
    [TestFixture]
    public class LoginTest : BaseTest.BaseTest
    {
        [Test]
        public void LoginCorrecto()
        {
            var loginPage = new LoginPage(Driver);
            loginPage.GoTo();

            loginPage.EnterUsername("student");
            loginPage.EnterPassword("Password123");
            loginPage.ClickSumbit();

            Thread.Sleep(3000);
        }

        [Test]
        public void LoginCorrectoV2()
        {
            var loginPage = new LoginPage(Driver);
            loginPage.Login("student", "Password123");

            string expectedUrl = "https://practicetestautomation.com/logged-in-successfully/";
            Assert.That(loginPage.GetCurrentUrl(), Is.EqualTo(expectedUrl));

            Thread.Sleep(3000);
        }

        [Test]
        public void LoginIncorrecto()
        {
            var loginPage = new LoginPage(Driver);
            loginPage.Login("student", "Password124");

            string expectedUrl = "https://practicetestautomation.com/logged-in-successfully/";
            Assert.That(loginPage.GetCurrentUrl(), Is.Not.EqualTo(expectedUrl));

            //Assert.That(loginPage.GetErrorMessage(), Is.EqualTo("Your Password is invalid!"));

            Thread.Sleep(3000);
        }
    }
}
