using OpenQA.Selenium.Support.UI;
using System;
using Xunit;

namespace bdd.workshop.calculator.test.selenium
{
    public class SquareRootSeleniumUnitTests : WebBrowser
    {
        [Theory(DisplayName = "Square Root Theory")]
        [Trait("TestType", "Functional Theories")]
        [InlineData(16, 4)]
        private void SquareRootTest(double number, double result)
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
            Assert.True(double.TryParse(outputResultString, out double outputResult));
            Assert.True(result == outputResult);
        }
    }
}
