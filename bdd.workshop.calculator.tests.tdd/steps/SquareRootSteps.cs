using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.CommonModels;
using Xunit;
using Xunit.Abstractions;

namespace bdd.workshop.calculator.tests.selenium.steps
{
    [Binding]
    public sealed class SquareRootSteps
    {
        private readonly ScenarioContext _scenarioContext;

        public SquareRootSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [When(@"number (.*) is added")]
        public void WhenNumberIsAdded(int number)
        {
            _scenarioContext.Add("SquareRoot", Operator.SquareRoot(number));

        }

        [Then(@"the result of the square root is (.*)")]
        public void ThenTheResultOfSquareRootIs(double result)
        {
            var res = _scenarioContext.Get<double>("SquareRoot");
            Assert.InRange(res, result - 0.01, result + 0.01);
        }
    }
}

