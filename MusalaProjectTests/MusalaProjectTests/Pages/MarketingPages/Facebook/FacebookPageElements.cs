using MusalaPorjectTests.Support;
using OpenQA.Selenium;

namespace MusalaProjectTests.Pages.MarketingPages
{
    public partial class FacebookPageElements
    {
        public static IWebElement ProfilePicture => DriverContext.WaitAndFindElement(By.Id(":r1:"));
    }
}
