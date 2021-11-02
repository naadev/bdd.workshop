using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
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
            int a = 1;
            int b = 2;
            double result = 3;
            string operation = "+";
            using IWebDriver driver = new ChromeDriver("C:\\CommonExePath\\");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var aXpath = "//input[@id='A']";
            var bXpath = "//input[@id='B']";
            var cmdXpath = "//input[@id='Command']";
            var submitButton = "//input[@type='submit']";
            driver.Url = "https://bdd-workshop-the-calculator.azurewebsites.net/Calculator";
            wait.Until(driver => driver.FindElement(By.XPath(aXpath)));
            wait.Until(driver => driver.FindElement(By.XPath(bXpath)));
            wait.Until(driver => driver.FindElement(By.XPath(cmdXpath)));
            wait.Until(driver => driver.FindElement(By.XPath(submitButton)));
            var inputA = driver.FindElement(By.XPath(aXpath));
            var inputCmd = driver.FindElement(By.XPath(cmdXpath));
            var inputB = driver.FindElement(By.XPath(bXpath));
            var button = driver.FindElement(By.XPath(submitButton));
            inputA.SendKeys(a.ToString());
            inputCmd.SendKeys(operation);
            inputB.SendKeys(b.ToString());
            button.Click();
            var theResult = "//td[@id='theResult']";
            wait.Until(driver => driver.FindElement(By.XPath(theResult)));
            var outputResultString = driver.FindElement(By.XPath(theResult)).Text;
            Assert.True(double.TryParse(outputResultString, out double outputResult));
            Assert.True(result == outputResult);
        }
        [Fact]
        [Trait("TestType", "FT")]
        public void BasicMultiply()
        {
            int a = 10;
            int b = 4;
            double result = 40;
            string operation = "x";
            using IWebDriver driver = new ChromeDriver("C:\\CommonExePath\\");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var aXpath = "//input[@id='A']";
            var bXpath = "//input[@id='B']";
            var cmdXpath = "//input[@id='Command']";
            var submitButton = "//input[@type='submit']";
            driver.Url = "https://bdd-workshop-the-calculator.azurewebsites.net/Calculator";
            wait.Until(driver => driver.FindElement(By.XPath(aXpath)));
            wait.Until(driver => driver.FindElement(By.XPath(bXpath)));
            wait.Until(driver => driver.FindElement(By.XPath(cmdXpath)));
            wait.Until(driver => driver.FindElement(By.XPath(submitButton)));
            var inputA = driver.FindElement(By.XPath(aXpath));
            var inputCmd = driver.FindElement(By.XPath(cmdXpath));
            var inputB = driver.FindElement(By.XPath(bXpath));
            var button = driver.FindElement(By.XPath(submitButton));
            inputA.SendKeys(a.ToString());
            inputCmd.SendKeys(operation);
            inputB.SendKeys(b.ToString());
            button.Click();
            var theResult = "//td[@id='theResult']";
            wait.Until(driver => driver.FindElement(By.XPath(theResult)));
            var outputResultString = driver.FindElement(By.XPath(theResult)).Text;
            Assert.True(double.TryParse(outputResultString, out double outputResult));
            Assert.True(result == outputResult);
        }
        [Fact]
        [Trait("TestType", "FT")]
        public void BasicDivide()
        {
            int a = 20;
            int b = 4;
            double result = 5;
            string operation = "/";
            using IWebDriver driver = new ChromeDriver("C:\\CommonExePath\\");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var aXpath = "//input[@id='A']";
            var bXpath = "//input[@id='B']";
            var cmdXpath = "//input[@id='Command']";
            var submitButton = "//input[@type='submit']";
            driver.Url = "https://bdd-workshop-the-calculator.azurewebsites.net/Calculator";
            wait.Until(driver => driver.FindElement(By.XPath(aXpath)));
            wait.Until(driver => driver.FindElement(By.XPath(bXpath)));
            wait.Until(driver => driver.FindElement(By.XPath(cmdXpath)));
            wait.Until(driver => driver.FindElement(By.XPath(submitButton)));
            var inputA = driver.FindElement(By.XPath(aXpath));
            var inputCmd = driver.FindElement(By.XPath(cmdXpath));
            var inputB = driver.FindElement(By.XPath(bXpath));
            var button = driver.FindElement(By.XPath(submitButton));
            inputA.SendKeys(a.ToString());
            inputCmd.SendKeys(operation);
            inputB.SendKeys(b.ToString());
            button.Click();
            var theResult = "//td[@id='theResult']";
            wait.Until(driver => driver.FindElement(By.XPath(theResult)));
            var outputResultString = driver.FindElement(By.XPath(theResult)).Text;
            Assert.True(double.TryParse(outputResultString, out double outputResult));
            Assert.True(result == outputResult);
        }

        [Fact]
        [Trait("TestType", "FT")]
        public void BasicSubstract()
        {
            int a = 20;
            int b = 4;
            double result = 16;
            string operation = "-";
            using IWebDriver driver = new ChromeDriver("C:\\CommonExePath\\");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var aXpath = "//input[@id='A']";
            var bXpath = "//input[@id='B']";
            var cmdXpath = "//input[@id='Command']";
            var submitButton = "//input[@type='submit']";
            driver.Url = "https://bdd-workshop-the-calculator.azurewebsites.net/Calculator";
            wait.Until(driver => driver.FindElement(By.XPath(aXpath)));
            wait.Until(driver => driver.FindElement(By.XPath(bXpath)));
            wait.Until(driver => driver.FindElement(By.XPath(cmdXpath)));
            wait.Until(driver => driver.FindElement(By.XPath(submitButton)));
            var inputA = driver.FindElement(By.XPath(aXpath));
            var inputCmd = driver.FindElement(By.XPath(cmdXpath));
            var inputB = driver.FindElement(By.XPath(bXpath));
            var button = driver.FindElement(By.XPath(submitButton));
            inputA.SendKeys(a.ToString());
            inputCmd.SendKeys(operation);
            inputB.SendKeys(b.ToString());
            button.Click();
            var theResult = "//td[@id='theResult']";
            wait.Until(driver => driver.FindElement(By.XPath(theResult)));
            var outputResultString = driver.FindElement(By.XPath(theResult)).Text;
            Assert.True(double.TryParse(outputResultString, out double outputResult));
            Assert.True(result == outputResult);
        }
        [Fact]
        [Trait("TestType", "FT")]
        public void DividingNonIntegerResult()
        {
            int a = 10;
            int b = 4;
            double result = 2.5;
            string operation = "/";
            using IWebDriver driver = new ChromeDriver("C:\\CommonExePath\\");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var aXpath = "//input[@id='A']";
            var bXpath = "//input[@id='B']";
            var cmdXpath = "//input[@id='Command']";
            var submitButton = "//input[@type='submit']";
            driver.Url = "https://bdd-workshop-the-calculator.azurewebsites.net/Calculator";
            wait.Until(driver => driver.FindElement(By.XPath(aXpath)));
            wait.Until(driver => driver.FindElement(By.XPath(bXpath)));
            wait.Until(driver => driver.FindElement(By.XPath(cmdXpath)));
            wait.Until(driver => driver.FindElement(By.XPath(submitButton)));
            var inputA = driver.FindElement(By.XPath(aXpath));
            var inputCmd = driver.FindElement(By.XPath(cmdXpath));
            var inputB = driver.FindElement(By.XPath(bXpath));
            var button = driver.FindElement(By.XPath(submitButton));
            inputA.SendKeys(a.ToString());
            inputCmd.SendKeys(operation);
            inputB.SendKeys(b.ToString());
            button.Click();
            var theResult = "//td[@id='theResult']";
            wait.Until(driver => driver.FindElement(By.XPath(theResult)));
            var outputResultString = driver.FindElement(By.XPath(theResult)).Text;
            Assert.True(double.TryParse(outputResultString, out double outputResult));
            Assert.True(result == outputResult);
            //Assert.True(Operator.Divide(a, b) == result);
        }
    }
}
