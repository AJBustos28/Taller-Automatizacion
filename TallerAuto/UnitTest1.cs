using System;
using System.Text;
using NUnit.Framework;                          // Framewor de testing NUnit
using OpenQA.Selenium;                          // webDriver base
using OpenQA.Selenium.Chrome;                   // Driver especifico para el navegador Chrome


namespace TallerAuto
{
    [TestFixture]
    public class PruebaLogin
    {
        private IWebDriver driver;              // WebDriver que controla el navegador
        private string baseUrl;                 // Url de la pagina de login

        private By tbxUsername = By.Id("username");                          // Localizador para el campo de username
        private By tbxPassword = By.XPath("//input[@id='password']");        // Localizador para el campo de contraseña
        private By btnSubmit = By.CssSelector("#submit");                   // Localizador para el boton de enviar

        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();                            //Inicializa el WebDriver para Chrome
            baseUrl = "https://practicetestautomation.com";         //Establece la URLbase para las pruebas de login
        }

        [TearDown]
        public void TearDown() 
        {
            try
            {
                driver.Dispose();
            }catch (Exception ex) { 
            }
        }

        [Test]
        public void Login()
        {
            // 1. Navega al formulario de login
            driver.Navigate().GoToUrl($"{baseUrl}/practice-test-login/");       // Navega a la página de la práctica

            //Assert.That(driver.FindElement(tbxUsername).Displayed,"No está");

            // 2. Interactúa con el campo "username"
            driver.FindElement(tbxUsername).Click();                //Hace clic en el campo
            driver.FindElement(tbxUsername).Clear();                //Limpia el contenido
            driver.FindElement(tbxUsername).SendKeys("student");    //Ingresa el usuario

            // 3. Interactúa con el campo "password"
            driver.FindElement(tbxPassword).Clear();                        //Limpia el contenido        
            driver.FindElement(tbxPassword).SendKeys("Password123");        //Ingresa el usuario

            // 4. Envia el formulario con el bóton 
            driver.FindElement(btnSubmit).Click();

            string expectedUrl = $"{baseUrl}/logged-in-successfully/";
            Assert.That(driver.Url.Equals(expectedUrl), "El login no fue exitoso");
        }
    }
}
