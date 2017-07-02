﻿using System;
using System.Threading;
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
            System.Environment.SetEnvironmentVariable("webdriver.chrome.driver", @"../driver/chromedriver");
            driver.Url = "http://localhost:13369/";
            Thread.Sleep(5000);
        }
        
        [Then(@"I should be able to contact QAWorks with the following information")]
        public void ThenIShouldBeAbleToContactQAWorksWithTheFollowingInformation(Table table)
        {
            IWebElement nameElement = driver.FindElement(By.Id("Name"));
            // Action can be performed on Input Button element
            nameElement.SendKeys("Hello World");
            Thread.Sleep(5000);
            IWebElement submitElement = driver.FindElement(By.Name("Send"));
            // Action can be performed on Input Button element
            submitElement.Submit();
        }
    }
}
