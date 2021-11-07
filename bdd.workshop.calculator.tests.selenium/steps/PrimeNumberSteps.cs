using System;
using TechTalk.SpecFlow;
using Xunit;

namespace bdd.workshop.calculator.tests.selenium.steps
{
    [Binding]
    public sealed class PrimeNumberSteps : WebBrowser
    {
        private readonly ScenarioContext _scenarioContext;

        public PrimeNumberSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [When(@"number (.*) is checked")]
        public void WhenNumberIsChecked(int number)
        {

        }
        
        [Then(@"the answer to know whether is prime or not is (.*)")]
        public void ThenTheAnswerToKnowWhetherIsPrimeOrNotIsUnknown(string primeNumberInfo)
        {
        }
    }
}
