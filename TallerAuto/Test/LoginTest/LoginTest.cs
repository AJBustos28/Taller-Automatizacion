using TallerAuto;
using TallerAuto.PageObject.LoginPage;

namespace TallerAuto.Test.LoginTest
{
    [TestFixture]
    public class LoginTest : BaseTest.BaseTest
    {
        [Test]
        public void Redireccion()
        {
            var loginPage = new LoginPage(Driver);
            loginPage.GoTo();
        }
    }
}
