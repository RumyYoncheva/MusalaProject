using MusalaProjectTests.Pages.HomePage;
using MusalaProjectTests.Pages.HomePage.ContactForm;
using NUnit.Framework.Internal;

namespace MusalaProjectTests.Tests.HomePageTests
{
    [TestFixture]
    public class ContactFormTests
    {
        [SetUp]
        public void SetUp()
        {
            DriverContext.SetBrowser(BrowserType.Chrome);
        }

        [Test, TestCaseSource(nameof(GetEmail))]        
        [Parallelizable(ParallelScope.Self)]
        public void AssertFieldValidationMessageAppearsWhenEmailIsInvalid(string email)
        {
            HomePage.GoTo();
            HomePage.ScrollToContacts();
            HomePage.ClickContactUs();
            ContactForm.FillContactForm(ContactFactory.CreateContact(email));

            ContactFormAssertions.AssertEmailFieldValidationAppears();
        }

        [TearDown]
        public void TearDown()
        {
            DriverContext.Quit();
        }

        public static Array GetEmail()
        {
            string[] emails = File.ReadAllLines("Emails.txt");

            return emails;
        }
    }
}