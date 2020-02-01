using GK_Part1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestProject.Common.Enums;
using TestProject.SDK;

namespace TestLocal
{
    [TestClass]
    public class UnitTest1
    {
        private static string DevToken = "k2EDITaudOQiYjlazTt3bBXl0LYcsLh5yeAKWi97hRU1";
        private static AutomatedBrowserType BrowserType = AutomatedBrowserType.Chrome;

    [TestMethod]
        public void TestMethod1()
        {
            using (Runner runner = RunnerFactory.Instance.CreateWeb(DevToken, BrowserType))
                runner.Run(new WebAut());
        }
    }
}
