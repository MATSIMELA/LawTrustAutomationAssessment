using System;
using TechTalk.SpecFlow;

namespace LawTrust_UI_TestAutomation.Features
{
    [Binding]
    public class Registrat
    {
        [Given(@"""(.*)"" Page is displayed")]
        public void GivenPageIsDisplayed(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
