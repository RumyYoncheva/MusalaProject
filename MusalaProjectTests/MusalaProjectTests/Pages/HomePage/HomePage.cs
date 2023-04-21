using MusalaPorjectTests.Support;
using OpenQA.Selenium.Interactions;

namespace MusalaProjectTests.Pages.HomePage
{
    public static partial class HomePage
    {
        public static void GoTo()
        {
            DriverContext.GoTo(DriverContext.GetUrl());
        }

        public static void ScrollToContacts()
        {
            Actions actions = new Actions(DriverContext.Driver);
            actions.MoveToElement(HomePageElements.ContactsSection);
            actions.Perform();
        }

        public static void ClickContactUs()
        {
            HomePageElements.ContactUsButton.Click();
        }

        public static void ClickCompanyTab()
        {
            HomePageElements.CompanyTab.Click();
        }
    }
}