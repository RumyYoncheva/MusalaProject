using OpenQA.Selenium.Interactions;
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
            JoinUsPageElements.AcceptCookiesButton.Click();
            Actions actions = new Actions(DriverContext.Driver);
            actions.MoveToElement(JoinUsPageElements.JobPosition1);
            actions.Perform();
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

            var JobListObjects = new List<JobListModel>();

            for(int i = 0; i < card.Count; i++)
            {
                var name = card.ElementAt(i).GetAttribute("href").Split("/")[4].Replace("-", " ");

                var job = new JobListModel()
                {
                    Name = GetName(card, card.Count),
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

        public static string GetName(IReadOnlyCollection<IWebElement> jobs, int jobCount)
        {
            string name = "";

            for (int i = 0; i < jobCount; i++)
            {
                name = jobs.ElementAt(i).GetAttribute("href").Split("/")[4].Replace("-", " ");

                if (name.Any(char.IsDigit))
                {
                    var words = name.Split(" ");
                    foreach (var word in words)
                    {
                        if (word.All(char.IsDigit))
                        {
                            break;
                        }

                        name = String.Concat(word, " ");
                    }
                }
            }

            return name;
        }
    }
}