namespace MusalaProjectTests.Support
{
    public static class CandidateInfoFactory
    {
        public static JobPopUpFormModel CreateCandidateInfoWithoutLinkdIn()
        {
            var candidateInfo = new JobPopUpFormModel()
            {
                Name = "Test",
                Email = "test@test",
                Mobile = "0891111111",
                LinkdInProfileLink = "",
                YourMessage = "test"
            };

            return candidateInfo;
        }
    }
}