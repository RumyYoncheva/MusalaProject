namespace MusalaProjectTests.Pages.CompanyTab
{
    public static class CompanyTabAssertons
    {
        public static void AssertLeadershipSectionIsVisible()
        {
            Assert.IsTrue(CompanyTabElements.LeadershipSection.Displayed);
        }
    }
}