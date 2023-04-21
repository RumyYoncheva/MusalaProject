using MusalaPorjectTests.Support;
using OpenQA.Selenium;
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
            //ScrollToFooter();
            //DriverContext.Driver.Manage().Cookies.AddCookie(new Cookie("CookieLawInfoConsent", "eyJuZWNlc3NhcnkiOnRydWUsImZ1bmN0aW9uYWwiOnRydWUsInBlcmZvcm1hbmNlIjp0cnVlLCJhbmFseXRpY3MiOnRydWUsImFkdmVydGlzZW1lbnQiOnRydWUsIm90aGVycyI6dHJ1ZX0=").Domain());
            //Thread.Sleep(100);
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