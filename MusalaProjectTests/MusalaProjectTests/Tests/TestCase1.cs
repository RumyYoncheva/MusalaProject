using MusalaPorjectTests.Support;
using MusalaProjectTests.Support;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;

namespace MusalaProjectTests
{
    public class TestCase1
    {
        private DriverContext _driver;

        [SetUp]
        public void SetUp()
        {
            _driver = new DriverContext();
            _driver.SetBrowser(BrowserType.Chrome.ToString());
        }

        [Test]
        public void Test1()
        {
            var sectionContacts = _driver.Driver.FindElement(By.ClassName("inner-wraper"));
            Actions actions = new Actions(_driver.Driver);
            actions.MoveToElement(sectionContacts);
            actions.Perform();
        }


        [TearDown]
        public void TearDown()
        {
            _driver.Driver.Quit();
        }

        /*
        public void OpenBrowser(BrowserType browserType)
        {
            switch (browserType)
            {
                case BrowserType.FireFox:
                    DriverContext.Driver = new FirefoxDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);

                    break;
                case BrowserType.Chrome:
                    DriverContext.Driver = new ChromeDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
            }
        }
        */
        private dynamic GetBrowserOptions(string browserName)
        {
            if (browserName == "Chrome")
                return new ChromeOptions();
            if (browserName == "FireFox")
                return new FirefoxOptions();

            return new ChromeOptions();

        }
    }
}