using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace bdd.workshop.calculator.test.selenium
{
    public class NumberPropertiesTests : WebBrowser
    {
        private const string CalculatorUrl = "https://bdd-workshop-the-calculator.azurewebsites.net/NumberProperties";
        private const string NumberXPath = @"//input[@id='TheNumber']";
        private const string SubmitButtonXPath = "//input[@type='submit']";
        private const string IsPrimeNumberXPath = "//td[@id='isPrimeNumber']";
        private const string IsNotPrimeNumberXPath = "//td[@id='IsNotPrimeNumber']";
        private const string IsUndefinedXPath = "//td[@id='IsUndefined']";

        private WebDriverWait Wait => new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

        [Theory(DisplayName = "Number Properties Prime Number Theory")]
        [Trait("TestType", "Functional Theories")]
        [InlineData(13, true, false, false)]
        [InlineData(86743, true, false, false)]
        [InlineData(1, false, true, false)]
        [InlineData(8, false, true, false)]
        [InlineData(369, false, true, false)]
        [InlineData(0, false, false, true)]
        public void PrimeNumberTest(int number, bool isPrime, bool isNotPrime, bool isUndefined)
        {
            NavigateToCalculatorPage();
            EnterNumberAndSubmit(number);
            VerifyNumberProperties(isPrime, isNotPrime, isUndefined);
        }

        private void NavigateToCalculatorPage()
        {
            Driver.Url = CalculatorUrl;
        }

        private void EnterNumberAndSubmit(int number)
        {
            var wait = Wait;
            var inputNumber = FindElement(NumberXPath, wait);
            var submitButton = FindElement(SubmitButtonXPath, wait);
            inputNumber.SendKeys(number.ToString());
            submitButton.Click();
        }

        private void VerifyNumberProperties(bool isPrime, bool isNotPrime, bool isUndefined)
        {
            var wait = Wait;
            var isPrimeNumberMark = FindElement(IsPrimeNumberXPath, wait).Text == "X";
            var isNotPrimeNumberMark = FindElement(IsNotPrimeNumberXPath, wait).Text == "X";
            var isUndefinedMark = FindElement(IsUndefinedXPath, wait).Text == "X";
            Assert.True(isPrime == isPrimeNumberMark);
            Assert.True(isNotPrime == isNotPrimeNumberMark);
            Assert.True(isUndefined == isUndefinedMark);
        }
    }
}
