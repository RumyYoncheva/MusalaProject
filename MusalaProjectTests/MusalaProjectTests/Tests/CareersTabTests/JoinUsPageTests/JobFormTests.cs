using MusalaProjectTests.Pages.CareersTab.JobPage;
using MusalaProjectTests.Pages.CareersTab.JobPage.JobFormPopUp;
using MusalaProjectTests.Pages.CareersTab.JoinUsPage;

namespace MusalaProjectTests.Tests.CareersTabTests.JoinUsPageTests
{
    public  class JobFormTests
    {
        [SetUp]
        public void SetUp()
        {
            DriverContext.SetBrowser(BrowserType.Chrome);

            JoinUsPage.GoTo();
            JoinUsPage.SelectFirstOpenPosition();
            JobPage.ClickApplyBtton();
        }

        [Test]
        public void AssertEmailFieldValidationIsPresent()
        {
            JobFormPopUp.FillJobForm(CandidateInfoFactory.CreateCandidateInfoWithoutLinkdIn());

            Assert.Multiple(() =>
            {
                JobFormPopUpAssertions.AssertEmailFieldValidationIsPresent();
                JobFormPopUpAssertions.AssertSendButtonIsDisabled();
            });
        }

        [Test]
        public void AssertFileValidationIsPresenetWhenUploadingIncorrectFile()
        {
            JobFormPopUp.UploadFile();

            JobFormPopUpAssertions.AssertFileUploadValidationIsPresent();
        }

        [TearDown]
        public void TearDown()
        {
            DriverContext.Quit();
        }
    }
}