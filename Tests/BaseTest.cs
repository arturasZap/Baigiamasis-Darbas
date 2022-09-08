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
        public static WrongLoginPage _wrongLoginPage;
        public static AddItemToCartPage _addItemToCartPage;
        public static RegistrationPage _registrationPage;
        public static LoginToPage _loginToPage;

        [OneTimeSetUp]
        public static void SetUp()
        {
            Driver = CustomDriver.GetChromeDriver();

            _selectPage = new SelectOctopusPage(Driver);
            _wrongLoginPage = new WrongLoginPage(Driver);
            _addItemToCartPage = new AddItemToCartPage(Driver);
            _registrationPage = new RegistrationPage(Driver);
            _loginToPage = new LoginToPage(Driver);


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
