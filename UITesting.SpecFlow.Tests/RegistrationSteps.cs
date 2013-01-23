using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace UITesting.SpecFlow.Tests
{
    [Binding]
    public class RegistrationSteps
    {
        IWebDriver driver;
        public RegistrationSteps()
        {
            driver = new ChromeDriver();
        }
        
        [Given(@"I am in home page")]
        public void GivenIAmInHomePage()
        {
            driver.Navigate().GoToUrl("http://localhost:54855/");
        }

        [When(@"I press click register link")]
        public void WhenIPressClickRegisterLink()
        {
            IWebElement query = driver.FindElement(By.Id("about-link"));
            query.Click();
        }

        [Then(@"I can see the registration page")]
        public void ThenICanSeeTheRegistrationPage()
        {
            var expectedPageTitle = "About - My ASP.NET MVC Application";
            var actualPageTitle = driver.Title;
            Assert.AreEqual(expectedPageTitle, actualPageTitle);
        }
    }
}
