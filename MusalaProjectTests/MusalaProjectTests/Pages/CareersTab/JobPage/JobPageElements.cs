namespace MusalaProjectTests.Pages.CareersTab.JobPage
{
    public partial class JobPageElements
    {
        public static IWebElement GeneralDescriptionSection => DriverContext.WaitAndFindElement(By.XPath("//*[@id=\"post-5751\"]/div/div[2]/div[1]/div[1]/div[1]/div[2]/h2"));
        public static IWebElement RequirementsSection => DriverContext.WaitAndFindElement(By.XPath("//*[@id=\"post-5751\"]/div/div[2]/div[1]/div[1]/div[2]/div[2]/h2"));
        public static IWebElement ResponsabilitiesSection => DriverContext.WaitAndFindElement(By.XPath("//*[@id=\"post-5751\"]/div/div[2]/div[1]/div[2]/div[1]/div[2]/h2"));
        public static IWebElement WhatWeOfferSection => DriverContext.WaitAndFindElement(By.XPath("//*[@id=\"post-5751\"]/div/div[2]/div[1]/div[2]/div[2]/div[2]/h2"));
        public static IWebElement ApplyButton => DriverContext.WaitAndFindElement(By.XPath("//*[@id=\"post-5751\"]/div/div[2]/div[2]/a/input"));
    }
}