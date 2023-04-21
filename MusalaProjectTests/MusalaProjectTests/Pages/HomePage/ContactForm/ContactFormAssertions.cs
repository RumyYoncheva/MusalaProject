using FluentAssertions;
using MusalaPorjectTests.Support;
using OpenQA.Selenium.Support.UI;

namespace MusalaProjectTests.Pages.HomePage.ContactForm
{
    public static class ContactFormAssertions
    {
        public static void AssertEmailFieldValidationAppears()
        {
            //WebDriverWait wait = new WebDriverWait(DriverContext.Driver, TimeSpan.FromMilliseconds(100));
            string validationMessageActual = ContactFormElements.FieldValidation.Text;

            string expectedValidationMessage = "The e-mail address entered is invalid.";

            validationMessageActual.Should().Be(expectedValidationMessage);


        }
    }
}
