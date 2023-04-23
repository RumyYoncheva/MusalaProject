namespace MusalaProjectTests.Pages.CareersTab.JobPage.JobFormPopUp
{
    public static partial class JobFormPopUp
    {
        public static void UploadFile()
        {
            JobFormPopUpElements.ChooseFileButton.SendKeys($"{Directory.GetCurrentDirectory()}/CV.txt");            
        }

        public static void FillJobForm(JobPopUpFormModel candidateInfo)
        {
            JobFormPopUpElements.NameField.SendKeys(candidateInfo.Name);
            JobFormPopUpElements.EmailField.SendKeys(candidateInfo.Email);
            JobFormPopUpElements.MobileField.SendKeys(candidateInfo.Mobile);
            JobFormPopUpElements.LinkdInProfileLinkField.SendKeys(candidateInfo.LinkdInProfileLink);
            JobFormPopUpElements.YourMessageField.SendKeys(candidateInfo.YourMessage);
        }

        public static void AcceptPolicy()
        {
            JobFormPopUpElements.PolicyAcceptCheckbox.Click();
        }

        public static void SendCandidateInfo(JobPopUpFormModel candidateInfo)
        {
            FillJobForm(candidateInfo);
            UploadFile();
            AcceptPolicy();
        }
    }
}