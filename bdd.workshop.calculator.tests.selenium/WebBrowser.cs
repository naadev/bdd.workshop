using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Runtime.InteropServices;

namespace bdd.workshop.calculator.tests.selenium
{
    public abstract class WebBrowser : IDisposable
    {
        protected IWebDriver Driver { get; set; }
        public WebBrowser()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--headless");
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                Driver = new ChromeDriver("C:\\CommonExePath\\", options);
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                options.AddArgument("--remote-debugging-port=9222");
                Driver = new ChromeDriver(options);
            }

        }

        public void Dispose()
        {
            Driver.Close();
            GC.SuppressFinalize(this);
        }
        protected IWebElement FindElement(string xpath, WebDriverWait wait)
        {
            wait.Until(driver => driver.FindElement(By.XPath(xpath)));
            return Driver.FindElement(By.XPath(xpath));
        }
    }
}
