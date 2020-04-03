using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ExampleProject.WebElements
{
    class LogInPage
    {
        public string homepage = "http://testing-ground.scraping.pro/login";

        private IWebDriver driver;

        readonly By userNameField = By.Id("usr");
        readonly By passwordField = By.Id("pwd");
        readonly By LogInButton = By.CssSelector("[type='submit']");
        readonly By WelcomeMessage = By.CssSelector("#case_login > h3");

        public LogInPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void enterUsername(string username)
        {
            driver.FindElement(userNameField).Clear();
            driver.FindElement(userNameField).SendKeys(username);
        }

        public void enterPassword(string password)
        {
            driver.FindElement(passwordField).Clear();
            driver.FindElement(passwordField).SendKeys(password);
        }

        public void clickLogInButton()
        {
            driver.FindElement(LogInButton).Click();
        }

        public bool isWelcomeMessageDisplayed()
        {
            return driver.FindElement(WelcomeMessage).Displayed;
        }
    }
}
