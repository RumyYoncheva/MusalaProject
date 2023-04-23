using FluentAssertions;
using OpenQA.Selenium.Support.UI;

namespace MusalaProjectTests.Pages.CareersTab.JoinUsPage
{
    public static class JoinUsPageAssertions
    {
        public static void AssertUrlIsCorrect()
        {
            DriverContext.Driver.Url.Should().Be("https://www.musala.com/careers/join-us/");
        }

        public static void AssertJobFilterDefaultValueIsCorrect()
        {
            SelectElement dropdownValue = new SelectElement(JoinUsPageElements.JobFilterDropdown);
            dropdownValue.SelectedOption.Text.Should().Be("All Locations");
        }
        public static void AssertJobFilterCityValueIsCorrect(string city)
        {
            JoinUsPage.PrintAllJobsListed(city);
            SelectElement dropdownValue = new SelectElement(JoinUsPageElements.JobFilterDropdown);
            dropdownValue.SelectedOption.Text.Should().Be(city);
        }
    }
}