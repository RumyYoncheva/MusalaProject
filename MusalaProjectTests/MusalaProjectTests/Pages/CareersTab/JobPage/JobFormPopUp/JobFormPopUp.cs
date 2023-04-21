namespace MusalaProjectTests.Pages.CareersTab.JobPage.JobFormPopUp
{
    public static partial class JobFormPopUp
    {
        public static void UploadFile()
        {
            JobFormPopUpElements.ChooseFileButton.SendKeys($"{Directory.GetCurrentDirectory()}/CV.txt");            
        }
    }
}