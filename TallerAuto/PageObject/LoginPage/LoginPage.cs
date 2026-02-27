using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TallerAuto.PageObject.LoginPage
{
    public class LoginPage : BasePage.BasePage
    {
        private readonly string loginUrl = "https://practicetestautomation.com/practice-test-login/";

        //Selectores para los elementos de la página de login
        private By tbxUsername = By.Id("username");                          // Localizador para el campo de username
        private By tbxPassword = By.XPath("//input[@id='password']");        // Localizador para el campo de contraseña
        private By btnSubmit = By.CssSelector("#submit");                   // Localizador para el boton de enviar

        //Selectores erroneos
        private By msgLoginIncorrecto = By.XPath("//div[@id='error']");

        public LoginPage(IWebDriver driver) : base(driver) { }

        public void GoTo()
        {
            _driver.Navigate().GoToUrl(loginUrl); //Navega a la página login
        }

        public void EnterUsername(string username)
        {
            WaitforElement(tbxUsername).Clear();
            _driver.FindElement(By.Id("username")).SendKeys(username);
        }
        public void EnterPassword(string password)
        {
            WaitforElement(tbxPassword).Clear();
            _driver.FindElement(By.Id("password")).SendKeys(password);
        }

        public void ClickSumbit()
        {
            ClickElement(btnSubmit);
        }

        public string GetErrorMessage()
        {
            return WaitforElement(msgLoginIncorrecto).Text;
        }

        public void Login(string username, string password)
        {
            GoTo();
            EnterUsername(username);
            EnterPassword(password);
            ClickSumbit();
        }
    }
}
