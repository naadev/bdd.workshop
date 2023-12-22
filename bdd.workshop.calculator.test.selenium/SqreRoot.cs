using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using Xunit;

namespace bdd.workshop.calculator.test.selenium
{
    public class SqreRoot : WebBrowser
    {   
        private void SquareRootTest(int number, double result)
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            var numberXPath = @"//input[@id='TheNumber']";
            var submitButton = "//input[@type='submit']";
            var url = "https://bdd-workshop-hector-betancourt.azurewebsites.net/";
            Driver.Url = $"{url}SqreRoot";
            var inputA = FindElement(numberXPath, wait);
            var button = FindElement(submitButton, wait);
            inputA.SendKeys(number.ToString());
            button.Click();
            var resultXPath = "//td[@id='theSqreResult']";
            var outputResultString = FindElement(resultXPath, wait).Text;
            outputResultString = outputResultString.Replace(',', '.');
            Assert.True(double.TryParse(outputResultString, CultureInfo.InvariantCulture, out double outputResult));
            Assert.InRange(outputResult, result - 0.01, result + 0.01);
        }
        [Theory(DisplayName = "Operations Theory")]
        [Trait("TestType", "Functional Theories")]
        [InlineData(25, 5)]
        [InlineData(30, 5.47)]
        [InlineData(49, 7)]
        [InlineData(121, 11)]
        [InlineData(50, 7.07)]
        public void OperationsTheory(int a, double result)
        {
            SquareRootTest(a, result);
        }
    }
}
