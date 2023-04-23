using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System.Reflection;

namespace MusalaProjectTests.Support
{
    public class ExtentReporting
    {
        private static ExtentTest _extentTests;
        private static ExtentReports _extentReports;

        private static ExtentReports StartReporting()
        {
            var path = String.Concat(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"\results\");

            if (_extentReports == null)
            {
                Directory.CreateDirectory(path);

                _extentReports = new ExtentReports();

                var htmlReporter = new ExtentHtmlReporter(path);

                _extentReports.AttachReporter(htmlReporter);
            }

            return _extentReports;
        }

        public static void CreaeTest(string name)
        {
            _extentTests = StartReporting().CreateTest(name);
        }

        public static void EndReporting()
        {
            StartReporting().Flush();
        }

        public static void LogInfo(string info)
        {
            _extentTests.Info(info);
        }

        public static void LogPass(string info)
        {
            _extentTests.Pass(info);
        }

        public static void LogFail(string info)
        {
            _extentTests.Fail(info);
        }
    }
}