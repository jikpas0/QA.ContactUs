using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace QA.ContactUs.Tests.FeatureTest
{
    [Binding]
    public class ContactUsPageSteps
    {
        private IWebDriver driver = new ChromeDriver();

        [Given(@"I am on the QAWorks Site")]
        public void GivenIAmOnTheQAWorksSite()
        {
            driver.Url = "http://localhost:13369/";
        }
        
        [Then(@"I should be able to contact QAWorks with the following information")]
        public void ThenIShouldBeAbleToContactQAWorksWithTheFollowingInformation(Table table)
        {
            IWebElement nameElement = driver.FindElement(By.Id("Name"));
            // Action can be performed on Input Button element
            nameElement.SendKeys("Hello World");

            IWebElement submitElement = driver.FindElement(By.Id("Send"));
            // Action can be performed on Input Button element
            submitElement.Submit();
        }
    }
}
