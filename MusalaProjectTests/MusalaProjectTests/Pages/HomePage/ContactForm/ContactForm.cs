using MusalaProjectTests.Models;

namespace MusalaProjectTests.Pages.HomePage.ContactForm
{
    public static partial class ContactForm
    {
        public static void FillContactForm(ContactFormModel contactForm)
        {
            ContactFormElements.Name.SendKeys(contactForm.FirstName);
            ContactFormElements.Email.SendKeys(contactForm.Email);
            ContactFormElements.Mobile.SendKeys(contactForm.Mobile);
            ContactFormElements.Subject.SendKeys(contactForm.Subject);
            ContactFormElements.YourMessage.SendKeys(contactForm.YourMessage);
        }
    }
}
