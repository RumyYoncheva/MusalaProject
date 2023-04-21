using MusalaPorjectTests.Support;
using OpenQA.Selenium;

namespace MusalaProjectTests.Pages.CareersTab.JoinUsPage
{
    public partial class JoinUsPageElements
    {
        public static IWebElement JobFilter => DriverContext.WaitAndFindElement(By.ClassName("job-filter"));

        public static IWebElement JobFilterDropdown => DriverContext.WaitAndFindElement(By.Id("get_location"));

        public static IWebElement JobPosition1 => DriverContext.WaitAndFindElement(By.XPath("//*[@id=\"content\"]/section/div[2]/article[1]/div/a"));

        public static IWebElement JobPositons => DriverContext.WaitAndFindElement(By.XPath("//*[@id=\"content\"]/section/div[2]"));
    }
}