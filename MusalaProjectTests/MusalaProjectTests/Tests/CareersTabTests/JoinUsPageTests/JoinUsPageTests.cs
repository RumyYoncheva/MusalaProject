using MusalaProjectTests.Pages.CareersTab;
using MusalaProjectTests.Pages.CareersTab.JoinUsPage;
using MusalaProjectTests.Pages.HomePage;

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
        [TestCase("Skopje")]
        public void AssertPositions(string city)
        {
            JoinUsPage.FilterJobPositionByCity(city);

            JoinUsPageAssertions.AssertJobFilterCityValueIsCorrect(city);
        }

        [TearDown]
        public void TearDown()
        {
            DriverContext.Quit();
        }
    }
}