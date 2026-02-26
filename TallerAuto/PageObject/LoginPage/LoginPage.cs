using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TallerAuto.PageObject.LoginPage
{
    public class LoginPage : BasePage.BasePage
    {
        private readonly string loginUrl = "https://practicetestautomation.com/practice-test-login/";

        private By tbxUsername = By.Id("username");                          // Localizador para el campo de username
        private By tbxPassword = By.XPath("//input[@id='password']");        // Localizador para el campo de contraseña
        private By btnSubmit = By.CssSelector("#submit");                   // Localizador para el boton de enviar
        
        public LoginPage(IWebDriver driver) : base(driver) { }

        public void GoTo()
        {
            _driver.Navigate().GoToUrl(loginUrl); //Navega a la página login
        }

        public void EnterUsername(string username)
        {
            _driver.FindElement(By.Id("username")).SendKeys(username);
        }
    }
}
