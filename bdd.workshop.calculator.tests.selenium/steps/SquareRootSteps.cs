using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.CommonModels;
using Xunit;
using Xunit.Abstractions;

namespace bdd.workshop.calculator.tests.selenium.steps
{
    [Binding]
    public sealed class SquareRootSteps: WebBrowser 
    {
        private readonly ScenarioContext _scenarioContext;

        public SquareRootSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _scenarioContext.Add("Wait", new WebDriverWait(Driver, TimeSpan.FromSeconds(10)));
        }
        [When(@"number (.*) is added")]
        public void WhenNumberIsAdded(int number)
        {
            var wait = _scenarioContext.Get<WebDriverWait>("Wait");
            var numberXPath = @"//input[@id='TheNumber']";
            var submitButton = "//input[@type='submit']";
            var url = "http://localhost:4234/";
            Driver.Url = $"{url}SqreRoot";
            var inputA = FindElement(numberXPath, wait);
            var button = FindElement(submitButton, wait);
            inputA.SendKeys(number.ToString());
            button.Click();
        }

        [Then(@"the result of the square root is (.*)")]
        public void ThenTheResultOfSquareRootIs(double result)
        {
            var wait = _scenarioContext.Get<WebDriverWait>("Wait");
            var resultXPath = "//td[@id='theSqreResult']";
            var outputResultString = FindElement(resultXPath, wait).Text;
            outputResultString = outputResultString.Replace(',', '.');
            Assert.True(double.TryParse(outputResultString, CultureInfo.InvariantCulture, out double outputResult));
            Assert.InRange(outputResult, result - 0.01, result + 0.01);
        }
    }
}

