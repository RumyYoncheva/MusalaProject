using MusalaProjectTests.Pages.CompanyTab;
using MusalaProjectTests.Pages.HomePage;
using MusalaProjectTests.Pages.MarketingPages.Facebook;

namespace MusalaProjectTests.Tests.CompanyTabTests
{
    public class CompanyTabTests
    {
        [SetUp]
        public void SetUp()
        {
            DriverContext.SetBrowser(BrowserType.Chrome);
        }

        [Test]
        public void AssertLeadershipSectionAppears()
        {
            HomePage.GoTo();
            HomePage.ClickCompanyTab();

            CompanyTabAssertons.AssertLeadershipSectionIsVisible();
        }

        [Test]
        public void AssertFacebookMarketingLinkIsCorrect()
        {
            CompanyTab.GoTo();
            CompanyTab.ClickFacebookMarketingButton();

            FacebookAssertions.AssertFacebookLinkIsCorrect();
        }

        [TearDown]
        public void TearDown()
        {
            DriverContext.Quit();
        }
    }
}