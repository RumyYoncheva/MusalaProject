using OpenQA.Selenium.Interactions;

namespace MusalaProjectTests.Pages.CompanyTab
{
    public static partial class CompanyTab
    {
        public static void GoTo()
        {
            DriverContext.GoTo("http://www.musala.com/company/");
        }

        public static void ClickFacebookMarketingButton()
        {
            ClickAcceptOnCookieBar();
            CompanyTabElements.FacebokFooterButton.Click();
        }

        public static void ScrollToFooter()
        {
            Actions actions = new Actions(DriverContext.Driver);
            actions.MoveToElement(CompanyTabElements.FooterSection);
            actions.Perform();
        }

        public static void ClickAcceptOnCookieBar()
        {
            ScrollToFooter();
            CompanyTabElements.CoockieBarAcceptButton.Click();
        }
    }
}