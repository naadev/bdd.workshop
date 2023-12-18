using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using Xunit;

namespace bdd.workshop.calculator.test.selenium
{
    public class CalculatorTests : WebBrowser
    {
        private void EvaluateOperation(int a, int b, string operation, double result)
        {
            const string calculatorUrl = "https://bdd-workshop-the-calculator.azurewebsites.net/Calculator";
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

            // Definir los XPaths
            var inputAXpath = "//input[@id='A_TheNumber']";
            var inputBXpath = "//input[@id='B_TheNumber']";
            var inputCmdXpath = "//input[@id='Command']";
            var submitButtonXpath = "//input[@type='submit']";
            var theResultXpath = "//td[@id='theResult']";

            // Navegar a la URL de la calculadora
            Driver.Url = calculatorUrl;

            // Encontrar elementos
            var inputA = FindElement(inputAXpath, wait);
            var inputCmd = FindElement(inputCmdXpath, wait);
            var inputB = FindElement(inputBXpath, wait);
            var submitButton = FindElement(submitButtonXpath, wait);

            // Ingresar datos y realizar la operación
            inputA.SendKeys(a.ToString());
            inputCmd.SendKeys(operation);
            inputB.SendKeys(b.ToString());
            submitButton.Click();

            // Verificar el resultado
            var outputResultString = FindElement(theResultXpath, wait).Text;
            Assert.True(double.TryParse(outputResultString, out double outputResult));
            Assert.True(result == outputResult);
        }
    

        [Theory(DisplayName ="Operations Theory")]
        [Trait("TestType", "Functional Theories")]
        [InlineData(1, "+", 2, 3)]
        [InlineData(10, "x", 4, 40)]
        [InlineData(20, "/", 4, 5)]
        [InlineData(20, "-", 4, 16)]
        [InlineData(10, "/", 4, 2.5)]
        public void OperationsTheory(int a, string operation, int b, double result)
        {
            EvaluateOperation(a, b, operation, result);
        }
        /// ***** COMMENTS ARE LEFT FOR COMPARISSON PURPOSES ONLY////
        //[Fact]
        //[Trait("TestType", "FT")]
        //public void BasicAdd()
        //{
        //    int a = 1;
        //    int b = 2;
        //    double result = 3;
        //    string operation = "+";
        //    EvaluateOperation(a, b, operation, result);
        //}
        //[Fact]
        //[Trait("TestType", "FT")]
        //public void BasicMultiply()
        //{
        //    int a = 10;
        //    int b = 4;
        //    double result = 40;
        //    string operation = "x";
        //    EvaluateOperation(a, b, operation, result);
        //}
        //[Fact]
        //[Trait("TestType", "FT")]
        //public void BasicDivide()
        //{
        //    int a = 20;
        //    int b = 4;
        //    double result = 5;
        //    string operation = "/";
        //    EvaluateOperation(a, b, operation, result);
        //}

        //[Fact]
        //[Trait("TestType", "FT")]
        //public void BasicSubstract()
        //{
        //    int a = 20;
        //    int b = 4;
        //    double result = 16;
        //    string operation = "-";
        //    EvaluateOperation(a, b, operation, result);
        //}
        //[Fact]
        //[Trait("TestType", "FT")]
        //public void DividingNonIntegerResult()
        //{
        //    int a = 10;
        //    int b = 4;
        //    double result = 2.5;
        //    string operation = "/";
        //    EvaluateOperation(a, b, operation, result);
        //}
    }
}
