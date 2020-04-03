using System;
using ExampleProject.WebElements;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace ExampleProject
{
    [Binding]
    public class LogInSteps : IDisposable
    {
        private ChromeDriver driver = new ChromeDriver();

        [Given(@"I navigate to Web Scraper home page")]
        public void GivenINavigateToWebScraperHomePage()
        {
            LogInPage logInPage = new LogInPage(driver);

            driver.Navigate().GoToUrl(logInPage.homepage);

            driver.Manage().Window.Maximize();
        }

        [When(@"I enter ""(.*)"" in the username field")]
        public void WhenIEnterInTheUsernameField(string userName)
        {
            LogInPage logInPage = new LogInPage(driver);

            logInPage.enterUsername(userName);
        }

        [When(@"I enter ""(.*)"" in the password field")]
        public void WhenIEnterInThePasswordField(string password)
        {
            LogInPage logInPage = new LogInPage(driver);

            logInPage.enterPassword(password);
        }

        [When(@"I click on Log in button")]
        public void WhenIClickOnLogInButton()
        {
            LogInPage logInPage = new LogInPage(driver);

            logInPage.clickLogInButton();
        }
        
        [Then(@"I should see Welcome message")]
        public void ThenIShouldSeeWelcomeMessage()
        {
            LogInPage logInPage = new LogInPage(driver);

            Assert.IsTrue(logInPage.isWelcomeMessageDisplayed());
        }

        public void Dispose()
        {
            if (driver != null)
            {
                driver.Dispose();
                driver = null;
            }
        }
    }
}
