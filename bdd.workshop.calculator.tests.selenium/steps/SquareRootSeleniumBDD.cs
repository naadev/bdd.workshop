using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;
using Xunit;

namespace bdd.workshop.calculator.tests.selenium.steps
{
    [Binding]
    public sealed class SquareRootSeleniumBDD : WebBrowser
    {
        private double SquareRootOperation(double number)
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            var numberXpath = "//input[@id='Number_TheNumber']";
            var submitButton = "//input[@type='submit']";
            Driver.Url = (Environment.GetEnvironmentVariable("BDD_WORKSHOP_URL_PREFIX") ?? "https://bdd-workshop-the-calculator.azurewebsites.net") + "/SquareRoot";
            var inputA = FindElement(numberXpath, wait);
            var button = FindElement(submitButton, wait);
            inputA.SendKeys(number.ToString());
            button.Click();
            var theResult = "//td[@id='result']";
            var outputResultString = FindElement(theResult, wait).Text;

            return double.Parse(outputResultString);
        }


        private readonly ScenarioContext _scenarioContext;

        public SquareRootSeleniumBDD(ScenarioContext scenarioContext)
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
            _scenarioContext.Add("Result", SquareRootOperation(number));
        }

        [When(@"the square root of a number (.*) is taken")]
        public void WhenTheSquareRootIsTaken(double number)
        {

            _scenarioContext.Add("Result", SquareRootOperation(number));
        }

        [Then(@"the result of square root operation should be (.*)")]
        public void ThenTheSquareRootResultShouldBe(double result)
        {
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
