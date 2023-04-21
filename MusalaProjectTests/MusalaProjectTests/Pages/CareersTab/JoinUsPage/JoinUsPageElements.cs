using MusalaPorjectTests.Support;
using OpenQA.Selenium;

namespace MusalaProjectTests.Pages.CareersTab.JoinUsPage
{
    public partial class JoinUsPageElements
    {
        public static IWebElement JobFilter => DriverContext.WaitAndFindElement(By.ClassName("job-filter"));

        public static IWebElement JobFilterDropdown => DriverContext.WaitAndFindElement(By.Id("get_location"));
    }
}