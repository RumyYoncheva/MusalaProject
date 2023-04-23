using Microsoft.Extensions.Configuration;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;

namespace MusalaPorjectTests.Support
{
    public class DriverContext
    {
        public static IWebDriver Driver { get; set; }
        public static WebDriverWait WebDriverWait { get; set; }

        public static void SetBrowser(BrowserType browser)
        {
            ExtentReporting.CreaeTest(TestContext.CurrentContext.Test.Name);

            switch (browser)
            {
                case BrowserType.Chrome:
                    var chromeDriverPath = new DriverManager().SetUpDriver(new ChromeConfig(), VersionResolveStrategy.MatchingBrowser);
                    string chromeDirectoryPath = Path.GetDirectoryName(chromeDriverPath);            
                    Driver = new ChromeDriver(chromeDirectoryPath);                    
                    break;
                case BrowserType.FireFox:
                    var firefoxDriverPath = "C:\\Program Files\\Mozilla Firefox";
                    Driver = new FirefoxDriver(firefoxDriverPath);
                    break;
                default: break;
            }

           Driver.Manage().Window.Maximize();           
           WebDriverWait = new WebDriverWait(Driver, TimeSpan.FromMilliseconds(30));
        }

        public static IWebElement WaitAndFindElement(By locator)
        {
            return WebDriverWait.Until(ExpectedConditions.ElementExists(locator));
        }

        public static void GoTo(string url = "")
        {
            if(url == "")
            {
                var config = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("config.json")
                    .Build();

                url = config.GetSection("BaseUrl").Value.ToString();
            }

            Driver.Navigate().GoToUrl(url);
        }

        public static void Quit()
        {
            EndTest();
            ExtentReporting.EndReporting();
            Driver.Quit();

        }

        private static void EndTest()
        {
            var testStatus = TestContext.CurrentContext.Result.Outcome.Status;
            var message = TestContext.CurrentContext.Result.Message;

            switch(testStatus)
            {
                case TestStatus.Failed:
                    ExtentReporting.LogFail($"Test has failed {message}");
                    break;
                case TestStatus.Skipped:
                    ExtentReporting.LogInfo($"Test skipped {message}");
                    break;
                default:
                    break;
            }

            ExtentReporting.LogInfo("Ending test");
        }
    }
}