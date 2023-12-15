using TechTalk.SpecFlow;
using Xunit;
using Xunit.Abstractions;

namespace bdd.workshop.calculator.tests.tdd.steps
{
    [Binding]
    public sealed class SquareRoot
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;
        private readonly ITestOutputHelper _output; // Output Helper

        public SquareRoot(ScenarioContext scenarioContext, ITestOutputHelper output)
        {
            _scenarioContext = scenarioContext;
            _output = output;
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

        [When(@"the square root of a number (.*) is taken")]
        public void WhenTheSquareRootIsTaken(double number)
        {

            _scenarioContext.Add("Result", Operator.SquareRoot(number));
        }

        [Then(@"the result of square root operation should be (.*)")]
        public void ThenTheSquareRootResultShouldBe(double result)
        {
            // Example of Output Helper usage
            // _output.WriteLine("Result from Operator {0}",  _scenarioContext.Get<double>("Result"));
            // _output.WriteLine("Expected result {0}", result);
            if(double.IsNaN(_scenarioContext.Get<double>("Result")))
            {
                Assert.True(double.IsNaN(result));
            }
            else
            {
                Assert.True(result == _scenarioContext.Get<double>("Result"));
            }
        }
    }
}
