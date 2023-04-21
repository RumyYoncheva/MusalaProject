using Microsoft.Extensions.Configuration;
using MusalaProjectTests.Support;
using OpenQA.Selenium;
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
            switch (browser)
            {
                case BrowserType.Chrome:
                    var chromeDriverPath = new DriverManager().SetUpDriver(new ChromeConfig(), VersionResolveStrategy.MatchingBrowser);
                    string chromeDirectoryPath = Path.GetDirectoryName(chromeDriverPath);
                    Driver = new ChromeDriver(chromeDirectoryPath);                    
                    break;
                case BrowserType.FireFox:
                    var firefoxDriverPath = "C:\\Program Files\\Mozilla Firefox";
                    new DriverManager().SetUpDriver(new FirefoxConfig(), VersionResolveStrategy.MatchingBrowser);
                    Driver = new FirefoxDriver(firefoxDriverPath);
                    break;
                default: break;

            }

            Driver.Manage().Window.Maximize();
            WebDriverWait = new WebDriverWait(Driver, TimeSpan.FromSeconds(30));
        }

        public static IWebElement WaitAndFindElement(By locator)
        {
            return WebDriverWait.Until(ExpectedConditions.ElementExists(locator));
        }

        public static void GoTo(string url)
        {
            Driver.Navigate().GoToUrl(url);
        }

        public static void Quit()
        {
            Driver.Quit();
        }

        public static string GetUrl()
        {
            var config = new ConfigurationBuilder()
             .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("config.json")
            .Build();

            string baseUrl = config.GetSection("BaseUrl").Value.ToString();

            return baseUrl;
        }
    }
}