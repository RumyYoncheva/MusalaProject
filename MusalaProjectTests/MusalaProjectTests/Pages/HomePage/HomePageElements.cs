using MusalaPorjectTests.Support;
using OpenQA.Selenium;

namespace MusalaProjectTests.Pages.HomePage
{
    public partial class HomePageElements
    {

        public static IWebElement ContactsSection => DriverContext.WaitAndFindElement(By.ClassName("contacts-title"));
        public static IWebElement ContactUsButton => DriverContext.WaitAndFindElement(By.XPath("/html/body/main/section[2]/div/div/div/a[1]/button"));
        public static IWebElement CompanyTab => DriverContext.WaitAndFindElement(By.XPath("//*[@id=\"menu-main-nav-1\"]/li[1]/a"));
        public static IWebElement CareersTab => DriverContext.WaitAndFindElement(By.XPath("//*[@id=\"menu-main-nav-1\"]/li[5]/a"));
    }
}