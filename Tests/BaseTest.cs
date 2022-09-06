using Baigiamasis_Projektas.Drivers;
using Baigiamasis_Projektas.Pages;
using Baigiamasis_Projektas.Tools;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;

namespace Baigiamasis_Projektas.Tests
{
    internal class BaseTest
    {
        protected static IWebDriver Driver;

        public static SelectOctopusPage _selectPage;
        public static wrongLoginPage _wrongLoginPage;

        [OneTimeSetUp]
        public static void SetUp()
        {
            Driver = CustomDriver.GetChromeDriver();

            _selectPage = new SelectOctopusPage(Driver);
            _wrongLoginPage = new wrongLoginPage(Driver);
            Driver.Manage().Window.Maximize();
        }

        [TearDown]
        public static void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                MyScreenshot.TakeScreenshot(Driver);
            }
        }

        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            Driver.Close();
        }
    }
}
