using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using Xunit;

namespace bdd.workshop.calculator.tests.selenium.steps
{
    [Binding]
    public sealed class SquareRootSteps:WebBrowser
    {
        private readonly ScenarioContext _scenarioContext;

        public SquareRootSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        public string EvaluateSquareRootOperation(int number)
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            var numberXPath = @"//input[@id='TheNumber']";
            var submitButton = "//input[@type='submit']";
            Driver.Url = "http://localhost:4234/SquareRoot";
            var inputA = FindElement(numberXPath, wait);
            var button = FindElement(submitButton, wait);
            inputA.SendKeys(number.ToString());
            button.Click();
            var outputResult = "//td[@id='theResult']";
            var outputResultString = FindElement(outputResult, wait).Text;
            return outputResultString;
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
            _scenarioContext.Add("Result", EvaluateSquareRootOperation(number));
        }

        [Then(@"the result must be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            Assert.True(result == int.Parse(_scenarioContext.Get<string>("Result")));
        }

        private void EvaluateNumberBox(int expectedNumber, string numberXPath)
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            var textInBox = FindElement(numberXPath, wait).Text;
            int.TryParse(textInBox, out int numberInBox);
            //Assert.True(int.TryParse(textInBox, out int numberInBox), $"{textInBox} is not an integer");
            Assert.Equal(numberInBox, expectedNumber);
        }

        [Then(@"displayed number is (.*)")]
        public void ThenDisplayedNumberIs(int number)
        {
            EvaluateNumberBox(number, "//td[@id='theNumber']");
        }
        [Then(@"displayed result is (.*)")]
        public void ThenDisplayedResultIs(int number)
        {
            EvaluateNumberBox(number, "//td[@id='theResult']");
        }
    }
}
