using MusalaPorjectTests.Support;
using MusalaProjectTests.Pages.CareersTab.JobPage;
using MusalaProjectTests.Pages.CareersTab.JobPage.JobFormPopUp;
using MusalaProjectTests.Pages.CareersTab.JoinUsPage;
using MusalaProjectTests.Support;

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
            var candidateInfo = new JobPopUpFormModel()
            {
                Name = "Test",
                Email = "test@test",
                Mobile = "0891111111",
                LinkdInProfileLink = "",
                YourMessage = "test"
            };

            JobFormPopUp.FillJobForm(candidateInfo);

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