using MusalaPorjectTests.Support;
using MusalaProjectTests.Pages.CompanyTab;
using MusalaProjectTests.Pages.HomePage;
using MusalaProjectTests.Pages.MarketingPages.Facebook;
using MusalaProjectTests.Support;

namespace MusalaProjectTests.Tests.CompanyTabTests
{
    [TestFixture]
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
        public void AssertFacebookMarketingLinkIsCorrectAndProfilePictureAppears()
        {
            CompanyTab.GoTo();
            CompanyTab.ClickFacebookMarketingButton();
            Assert.Multiple(() =>
            {
                FacebookAssertions.AssertFacebookLinkIsCorrect();
                FacebookAssertions.AssertProfilePictureAppears();
            });
        }

        [TearDown]
        public void TearDown()
        {
            DriverContext.Quit();
        }
    }
}
