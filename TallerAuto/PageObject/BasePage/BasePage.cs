using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TallerAuto.PageObject.BasePage
{
    public class BasePage
    {
        protected IWebDriver _driver;
        protected WebDriverWait wait;

        public BasePage(IWebDriver driver)
        {
            _driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }
    }
}
