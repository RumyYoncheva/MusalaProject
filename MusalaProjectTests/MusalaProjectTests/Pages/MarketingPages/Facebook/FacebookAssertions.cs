﻿using FluentAssertions;
using MusalaPorjectTests.Support;
using OpenQA.Selenium;

namespace MusalaProjectTests.Pages.MarketingPages.Facebook
{
    public static class FacebookAssertions
    {
        public static void AssertProfilePictureAppears()
        {
            var href = FacebookPageElements.ProfilePicture.GetAttribute("href");
            FacebookPageElements.ProfilePicture.GetAttribute("href").Should().NotBeNull();
        }

        public static void AssertFacebookLinkIsCorrect()
        {
            DriverContext.Driver.SwitchTo().Window(DriverContext.Driver.WindowHandles[1]);
            DriverContext.Driver.Manage().Cookies.AddCookie(new Cookie("datr", "jVJCZOaCM0sIRT-BEkXM_B5P"));
            DriverContext.Driver.Navigate().Refresh();
            DriverContext.Driver.Url.Should().Be("https://www.facebook.com/MusalaSoft?fref=ts");
        }
    }
}