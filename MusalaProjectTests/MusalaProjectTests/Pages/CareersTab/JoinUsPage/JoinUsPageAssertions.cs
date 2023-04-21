using FluentAssertions;
using MusalaPorjectTests.Support;
using OpenQA.Selenium;
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
    }
}