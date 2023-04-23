namespace MusalaProjectTests.Pages.CompanyTab
{
    public static partial class CompanyTabElements
    {
        public static IWebElement LeadershipSection => DriverContext.WaitAndFindElement(By.ClassName("company-members"));

        public static IWebElement FooterSection => DriverContext.WaitAndFindElement(By.ClassName("footer-links"));

        public static IWebElement FacebokFooterButton => DriverContext.WaitAndFindElement(By.CssSelector("html > body > footer > div > div > a:nth-of-type(4)"));

        public static IWebElement CoockieBarAcceptButton => DriverContext.WaitAndFindElement(By.ClassName("cli-bar-btn_container"));
    }
}