using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using Xunit;

namespace bdd.workshop.calculator.test.selenium
{
    public class CalculatorTests
    {
        
        [Fact]
        [Trait("TestType", "FT")]
        public void BasicAdd()
        {
            using IWebDriver driver = new ChromeDriver("C:\\CommonExePath\\");
            int a = 1;
            int b = 2;
            double result = 3;
            driver.Url = "https://bdd-workshop-the-calculator.azurewebsites.net/Calculator";
            driver.Url = "https://bdd-workshop-the-calculator.azurewebsites.net/Calculator";
            var inputA = driver.FindElement(By.XPath("//input[@id='A']"));
            var inputCmd = driver.FindElement(By.XPath("//input[@id='Command']"));
            var inputB = driver.FindElement(By.XPath("//input[@id='B']"));
            var button = driver.FindElement(By.XPath("//input[@type='submit']"));
            inputA.SendKeys(a.ToString());
            inputCmd.SendKeys("+");
            inputB.SendKeys(b.ToString());
            button.Click();
            //Assert.True(Operator.Add(a, b) == result);
        }
        [Fact]
        [Trait("TestType", "FT")]
        public void BasicMultiply()
        {
            using IWebDriver driver = new ChromeDriver("C:\\CommonExePath\\");
            int a = 10;
            int b = 4;
            double result = 40;
            driver.Url = "https://bdd-workshop-the-calculator.azurewebsites.net/Calculator";
            //Assert.True(Operator.Multiply(a, b) == result);
        }
        [Fact]
        [Trait("TestType", "FT")]
        public void BasicDivide()
        {
            using IWebDriver driver = new ChromeDriver("C:\\CommonExePath\\");
            int a = 20;
            int b = 4;
            double result = 5;
            //Assert.True(Operator.Divide(a, b) == result);
        }

        [Fact]
        [Trait("TestType", "FT")]
        public void BasicSubstract()
        {
            using IWebDriver driver = new ChromeDriver("C:\\CommonExePath\\");
            int a = 20;
            int b = 4;
            double result = 16;
            driver.Url = "https://bdd-workshop-the-calculator.azurewebsites.net/Calculator";
            //Assert.True(Operator.Substract(a, b) == result);
        }
        [Fact]
        [Trait("TestType", "FT")]
        public void DividingNonIntegerResult()
        {
            using IWebDriver driver = new ChromeDriver("C:\\CommonExePath\\");
            int a = 10;
            int b = 4;
            double result = 2.5;
            driver.Url = "https://bdd-workshop-the-calculator.azurewebsites.net/Calculator";
            //Assert.True(Operator.Divide(a, b) == result);
        }
    }
}
