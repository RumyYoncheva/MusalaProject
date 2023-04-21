using MusalaPorjectTests.Support;
using MusalaProjectTests.Support;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace MusalaProjectTests.Pages.CareersTab.JoinUsPage
{
    public static partial class JoinUsPage
    {
        public static void GoTo()
        {
            DriverContext.GoTo("http://www.musala.com/careers/join-us/");
        }

        public static void SelectFirstOpenPosition()
        {
            JoinUsPageElements.JobPosition1.Click();
        }

        public static void FilterJobPositionByCity(string  city)
        {
            SelectElement dropdownValue = new SelectElement(JoinUsPageElements.JobFilterDropdown);
            dropdownValue.SelectByText(city);
        }

        public static void PrintAllJobsListed(string city)
        {
            var card = JoinUsPageElements.JobPositons.FindElements(By.ClassName("card-jobsHot__link"));
            var articleCount = card.Count();

            var JobListObjects = new List<JobListModel>();

            for(int i = 0; i < articleCount; i++)
            {
                var name = card.ElementAt(i).GetAttribute("href").Split("/")[4].Replace("-", " ");

                if (name.Any(char.IsDigit))
                {
                    var words = name.Split(" ");
                    foreach(var word in words)
                    {
                        if (word.All(char.IsDigit))
                        {
                            break;
                        }
                        name = String.Concat(word, " ");
                    }
                }

                var job = new JobListModel()
                {
                    Name = name,
                    Link = card.ElementAt(i).GetAttribute("href")
                };

                JobListObjects.Add(job);
            }

            Console.WriteLine(city);

            foreach(var job in JobListObjects)
            {
                Console.WriteLine($"Position: {job.Name}");
                Console.WriteLine($"More information: {job.Link}");
            }
        }
    }
}