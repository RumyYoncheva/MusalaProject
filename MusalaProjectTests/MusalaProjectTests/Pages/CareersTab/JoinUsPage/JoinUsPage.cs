using MusalaPorjectTests.Support;

namespace MusalaProjectTests.Pages.CareersTab.JoinUsPage
{
    public static partial class JoinUsPage
    {
        public static void GoTo()
        {
            DriverContext.GoTo("http://www.musala.com/careers/join-us/");
        }

        public static void SelectFirstOpenPosition()
        {
            JoinUsPageElements.JobPosition1.Click();
        }
    }
}
