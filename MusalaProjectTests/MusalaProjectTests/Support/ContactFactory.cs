namespace MusalaProjectTests.Support
{
    public static class ContactFactory
    {
        public static ContactFormModel CreateContact(string email)
        {
            var contactInfo = new ContactFormModel
            {
                FirstName = "Rumyana",
                Email = email,
                Mobile = "",
                Subject = "Test",
                YourMessage = "Test"
            };

            return contactInfo;
        }
    }
}
