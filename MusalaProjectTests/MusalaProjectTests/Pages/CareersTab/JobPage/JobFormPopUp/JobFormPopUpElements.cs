using MusalaPorjectTests.Support;
using OpenQA.Selenium;

namespace MusalaProjectTests.Pages.CareersTab.JobPage.JobFormPopUp
{
    public partial class JobFormPopUpElements
    {
        public static IWebElement NameField => DriverContext.WaitAndFindElement(By.Id("cf-1"));
        public static IWebElement EmailField => DriverContext.WaitAndFindElement(By.Id("cf-2"));
        public static IWebElement MobileField => DriverContext.WaitAndFindElement(By.Id("cf-3"));
        public static IWebElement ChooseFileButton => DriverContext.WaitAndFindElement(By.Id("cf-4"));
        public static IWebElement LinkdInProfileLinkField => DriverContext.WaitAndFindElement(By.Id("cf-5"));
        public static IWebElement YourMessageField => DriverContext.WaitAndFindElement(By.Id("cf-6"));
        public static IWebElement PolicyAcceptCheckbox => DriverContext.WaitAndFindElement(By.Id("adConsentChx"));
        public static IWebElement SendButton => DriverContext.WaitAndFindElement(By.XPath("//*[@id=\"wpcf7-f880-o1\"]/form/div[4]/p/input"));

        //disabled when the form is not correct
    }
}