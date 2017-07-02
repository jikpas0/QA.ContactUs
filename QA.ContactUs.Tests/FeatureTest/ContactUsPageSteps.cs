using System;
using System.Collections.Generic;
using System.Threading;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow.Assist;

namespace QA.ContactUs.Tests.FeatureTest
{
    [Binding]
    public class ContactUsPageSteps
    {
        
        private IWebDriver driver = new ChromeDriver();

        [Given(@"I am on the QAWorks Site")]
        public void GivenIAmOnTheQAWorksSite()
        {
            System.Environment.SetEnvironmentVariable("webdriver.chrome.driver", @"../driver/chromedriver");
            driver.Url = "http://localhost:13369/";
            Thread.Sleep(1000);
        }
        
        [Then(@"I should be able to contact QAWorks with the following information")]
        public void ThenIShouldBeAbleToContactQAWorksWithTheFollowingInformation(Table table)
        {
            var dictionary = TableExtensions.ToDictionary(table);
            IWebElement nameElement = driver.FindElement(By.Id("Name"));
            nameElement.SendKeys(dictionary["name"]);
            Thread.Sleep(1000);

            IWebElement emailElement = driver.FindElement(By.Id("Email"));
            emailElement.SendKeys(dictionary["email"]);
            Thread.Sleep(1000);

            IWebElement messageElement = driver.FindElement(By.Id("Message"));
            messageElement.SendKeys(dictionary["message"]);
            Thread.Sleep(1000);

            IWebElement submitElement = driver.FindElement(By.Name("Send"));
            submitElement.Submit();
        }
    }

    public class TableExtensions
    {
        public static Dictionary<string, string> ToDictionary(Table table)
        {
            var dictionary = new Dictionary<string, string>();
            foreach (var row in table.Rows)
            {
                dictionary.Add(row[0], row[1]);
            }
            return dictionary;
        }
    }
}
