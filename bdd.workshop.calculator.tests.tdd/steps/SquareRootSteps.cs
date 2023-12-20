using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using Xunit;

namespace bdd.workshop.calculator.tests.tdd.steps
{
    [Binding]
    public class SquareRootSteps
    {

        private readonly ScenarioContext _scenarioContext;

        public SquareRootSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"the number (.*)")]
        public void GivenTheNumber(int number)
        {
            _scenarioContext.Add("Number", number);
        }

        [When(@"get the square root")]
        public void WhenGetTheSquareRoot()
        {
            var number = _scenarioContext.Get<int>("Number");
            _scenarioContext.Add("Result", Operator.SquareRoot(number));
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(double result)
        {
            Assert.True(result == _scenarioContext.Get<double>("Result"));
        }
    }
}
