using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace bdd.workshop.calculator.test.selenium
{
    public class SquareRoot: WebBrowser
    {
        [Theory(DisplayName = "Square Root Theory")]
        [Trait("TestType", "Functional Theories")]
        [InlineData(0, 0)]
        [InlineData(4, 2)]
        [InlineData(9, 3)]
        [InlineData(16, 4)]
        public void SquareRooTest(int number, double result)
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            var numberXPath = @"//input[@id='TheNumber']";
            var submitButton = "//input[@type='submit']";
            Driver.Url = "https://ugrdeployment.azurewebsites.net/SquareRoot";
            var inputA = FindElement(numberXPath, wait);
            var button = FindElement(submitButton, wait);
            inputA.SendKeys(number.ToString());
            button.Click();
            var outputResult = "//td[@id='theResult']";
            var outputResultString = FindElement(outputResult, wait).Text;
            double.TryParse(outputResultString, out double doubleOutPutResult);
            Assert.Equal(result, doubleOutPutResult);
        }
    }
}
