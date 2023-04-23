using FluentAssertions;

namespace MusalaProjectTests.Pages.HomePage.ContactForm
{
    public static class ContactFormAssertions
    {
        public static void AssertEmailFieldValidationAppears()
        {
            string validationMessageActual = ContactFormElements.FieldValidation.Text;

            string expectedValidationMessage = "The e-mail address entered is invalid.";

            validationMessageActual.Should().Be(expectedValidationMessage);
        }
    }
}