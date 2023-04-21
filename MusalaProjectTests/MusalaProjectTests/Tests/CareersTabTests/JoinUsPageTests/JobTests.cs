using MusalaPorjectTests.Support;
using MusalaProjectTests.Pages.CareersTab;
using MusalaProjectTests.Pages.CareersTab.JobPage;
using MusalaProjectTests.Pages.CareersTab.JoinUsPage;
using MusalaProjectTests.Pages.HomePage;
using MusalaProjectTests.Support;

namespace MusalaProjectTests.Tests.CareersTabTests.JoinUsPageTests
{
    public class JobTests
    {
        [SetUp]
        public void SetUp()
        {
            DriverContext.SetBrowser(BrowserType.Chrome);
        }

        [Test]
        public void AssertJobFilterDropdownDefaultIsCorrect()
        {
            HomePage.GoTo();
            HomePage.ClickCareersTab();
            CareersTab.ClickCheckOurOpenPositionsBtton();

            JoinUsPageAssertions.AssertJobFilterDefaultValueIsCorrect();
        }

        [Test]
        public void AssertJobSectionsAndApplyButtonArePresent()
        {
            HomePage.GoTo();
            HomePage.ClickCareersTab();
            CareersTab.ClickCheckOurOpenPositionsBtton();

            JoinUsPage.SelectFirstOpenPosition();

            Assert.Multiple(() =>
            {
                JobPageAssertions.AssertAllSectionsAppear();
                JobPageAssertions.AssertApplyButtonIsPresent();
            });
        }

        [TearDown]
        public void TearDown()
        {
            DriverContext.Quit();
        }
    }
}