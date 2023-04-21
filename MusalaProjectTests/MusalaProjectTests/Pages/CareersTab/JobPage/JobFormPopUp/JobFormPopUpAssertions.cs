using FluentAssertions;

namespace MusalaProjectTests.Pages.CareersTab.JobPage.JobFormPopUp
{
    public static class JobFormPopUpAssertions
    {
        public static void AssertEmailFieldValidationIsPresent()
        {
            string validationMessageActual = JobFormPopUpElements.EmailValidation.Text;

            string expectedValidationMessage = "The e-mail address entered is invalid.";

            validationMessageActual.Should().Be(expectedValidationMessage);
        }
        public static void AssertSendButtonIsDisabled()
        {
            JobFormPopUpElements.SendButton.Enabled.Should().BeFalse();
        }

        public static void AssertFileUploadValidationIsPresent()
        {
            JobFormPopUpElements.FileUploadValidation.Text.Should().Be("You are not allowed to upload files of this type.");
        }
    }
}