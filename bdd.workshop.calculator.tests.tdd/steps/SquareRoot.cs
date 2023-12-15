using TechTalk.SpecFlow;
using Xunit;

namespace bdd.workshop.calculator.tests.tdd.steps
{
    [Binding]
    public sealed class SquareRoot
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public SquareRoot(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"the number is (.*)")]
        public void GivenTheNumberIs(double number)
        {
            _scenarioContext.Add("Number", number);
        }

        [When(@"the square root from the number is taken")]
        public void WhenTheSquareRootIsTaken()
        {
            var number = _scenarioContext.Get<double>("Number");
            _scenarioContext.Add("Result", Operator.SquareRoot(number));
        }

        [Then(@"the square root of the number should be (.*)")]
        public void ThenTheSquareRootResultShouldBe(double result)
        {
            Assert.True(result == _scenarioContext.Get<double>("Result"));
        }
    }
}
