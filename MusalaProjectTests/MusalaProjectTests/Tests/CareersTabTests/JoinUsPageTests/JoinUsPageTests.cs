using MusalaProjectTests.Pages.CareersTab.JoinUsPage;
using MusalaProjectTests.Pages.CareersTab;
using MusalaProjectTests.Pages.HomePage;
using MusalaPorjectTests.Support;
using MusalaProjectTests.Support;

namespace MusalaProjectTests.Tests.CareersTabTests.JoinUsPageTests
{
    public class JoinUsPageTests
    {
        [SetUp]
        public void SetUp()
        {
            DriverContext.SetBrowser(BrowserType.Chrome);
            HomePage.GoTo();
            HomePage.ClickCareersTab();
            CareersTab.ClickCheckOurOpenPositionsBtton();
        }

        [Test]
        public void AssertJoinUsPageIsCorrect()
        {
            JoinUsPageAssertions.AssertUrlIsCorrect();
        }

        [Test]
        [TestCase("Sofia")]
        //[TestCase("Skopije")]
        public void AssertPositions(string city)
        {
            JoinUsPage.FilterJobPositionByCity(city);
            JoinUsPage.PrintAllJobsListed(city);

            /*
            JoinUsPage.FilterJobPositionByCity("Skopje");
            JoinUsPage.PrintAllJobsListed();
            */

        }

        [TearDown]
        public void TearDown()
        {
            DriverContext.Quit();
        }
    }
}
