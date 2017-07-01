using System;
using TechTalk.SpecFlow;

namespace QA.ContactUs.Tests.FeatureTest
{
    [Binding]
    public class ContactUsPageSteps
    {
        [Given(@"I am on the QAWorks Site")]
        public void GivenIAmOnTheQAWorksSite()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be able to contact QAWorks with the following information")]
        public void ThenIShouldBeAbleToContactQAWorksWithTheFollowingInformation(Table table)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
