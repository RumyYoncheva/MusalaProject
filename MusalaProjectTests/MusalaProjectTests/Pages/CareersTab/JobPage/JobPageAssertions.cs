using FluentAssertions;

namespace MusalaProjectTests.Pages.CareersTab.JobPage
{
    public static class JobPageAssertions
    {
        public static void AssertAllSectionsAppear()
        {
            Assert.Multiple(() =>
            {
                JobPageElements.GeneralDescriptionSection.Text.Should().Be("General description");
                JobPageElements.RequirementsSection.Text.Should().Be("Requirements");
                JobPageElements.ResponsabilitiesSection.Text.Should().Be("Responsibilities");
                JobPageElements.WhatWeOfferSection.Text.Should().Be("What we offer");
            });
        }

        public static void AssertApplyButtonIsPresent()
        {
            JobPageElements.ApplyButton.Enabled.Should().BeTrue();
        }
    }
}