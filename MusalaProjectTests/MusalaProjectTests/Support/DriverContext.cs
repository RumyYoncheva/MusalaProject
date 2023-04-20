using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;


namespace MusalaPorjectTests.Support
{
    public class DriverContext
    {
        private IWebDriver _driver;
        public IWebDriver Driver { get; set; }

        //private Config _config;

        //public DriverContext() { }

        /*
        public DriverContext(Config config)
        {
            _config = config;
        }
        */

        //public string BaseUrl { get; set; }



        public void SetBrowser(string browser)
        {

            switch (browser)
            {
                case "Chrome"
            }
            if (browser == "Chrome")
            {
                var chromeDriverPath = new DriverManager().SetUpDriver(new ChromeConfig(), VersionResolveStrategy.MatchingBrowser);
                string chromeDirectoryPath = Path.GetDirectoryName(chromeDriverPath);
                _driver = new ChromeDriver(chromeDirectoryPath);
            }

            if (browser == "Firefox")
            {
                var firefoxDriverPath = "C:\\Program Files\\Mozilla Firefox";
                _driver = new FirefoxDriver(firefoxDriverPath);
            }

            Driver = _driver;
            _driver.Navigate().GoToUrl(GetUrl());
        }

        public string GetUrl()
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