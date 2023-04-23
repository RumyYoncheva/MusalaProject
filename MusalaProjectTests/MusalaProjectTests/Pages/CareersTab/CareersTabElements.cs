namespace MusalaProjectTests.Pages.CareersTab
{
    public partial class CareersTabElements
    {
        public static IWebElement CheckOurOpenPositionsButton => DriverContext.WaitAndFindElement(By.XPath("//*[@id=\"content\"]/div[1]/div/div[1]/div/section/div/a"));
    }
}