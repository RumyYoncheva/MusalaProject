namespace MusalaProjectTests.Pages.HomePage.ContactForm
{
    public partial class ContactFormElements
    {
        public static IWebElement Name => DriverContext.WaitAndFindElement(By.Name("your-name"));
        public static IWebElement Email => DriverContext.WaitAndFindElement(By.Name("your-email"));
        public static IWebElement Mobile => DriverContext.WaitAndFindElement(By.Name("mobile-number"));
        public static IWebElement Subject => DriverContext.WaitAndFindElement(By.Name("your-subject"));
        public static IWebElement YourMessage => DriverContext.WaitAndFindElement(By.Name("your-message"));
        public static IWebElement FieldValidation => DriverContext.WaitAndFindElement(By.XPath("/html/body/div[8]/div/div[9]/div/div/div/form/p[2]/span/span"));        
    }
}