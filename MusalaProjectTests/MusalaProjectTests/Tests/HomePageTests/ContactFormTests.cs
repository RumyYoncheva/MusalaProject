using MusalaPorjectTests.Support;
using MusalaProjectTests.Models;
using MusalaProjectTests.Pages.HomePage;
using MusalaProjectTests.Pages.HomePage.ContactForm;
using MusalaProjectTests.Support;
using NUnit.Framework.Internal;

namespace MusalaProjectTests.Tests.HomePageTests
{
    public class ContactFormTests
    {
        [SetUp]
        public void SetUp()
        {
            DriverContext.SetBrowser(BrowserType.Chrome);
        }

        [Test, TestCaseSource(nameof(GetEmail))]        
        [Parallelizable(ParallelScope.Self)]
        public void AssertFieldValidationMessageAppearsWhenEmailIsInvalid()
        {
            HomePage.GoTo();
            HomePage.ScrollToContacts();
            HomePage.ClickContactUs();


            var contactInfo = new ContactFormModel
            {
                FirstName = "Rumyana",
                Email = "test",
                Mobile = "",
                Subject = "Test",
                YourMessage = "Test"
            };

            ContactForm.FillContactForm(contactInfo);

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