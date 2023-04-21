using MusalaPorjectTests.Support;

namespace MusalaProjectTests.Pages.CareersTab
{
    public static partial class CareersTab
    {
        public static void GoTo()
        {
            DriverContext.GoTo("http://www.musala.com/careers/");
        }
        
        public static void ClickCheckOurOpenPositionsBtton()
        {
            CareersTabElements.CheckOurOpenPositionsButton.Click();
        }
    }
}
