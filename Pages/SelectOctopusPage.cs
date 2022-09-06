using NUnit.Framework;
using OpenQA.Selenium;

namespace Baigiamasis_Projektas.Pages
{
    internal class SelectOctopusPage : BasePage
    {
        public SelectOctopusPage(IWebDriver webDriver) : base(webDriver) { }





        private const string PageAddress = "https://www.astuonkojis.lt/";

        private IWebElement _seaFood => Driver.FindElement(By.Id("top_menu_link_19880"));

        private IWebElement _octopus => Driver.FindElement(By.XPath("//*[@id=\"block_catalogmenu_body\"]/ul/li[1]"));

        private IWebElement _resultOfSearch => Driver.FindElement(By.Id("heading1"));

        private IWebElement _popUpAge => Driver.FindElement(By.CssSelector("#age-verification > a.button.yes.fl"));





        public SelectOctopusPage AgePopUpAgree()

        {
            _popUpAge.Click();
            return this;

        }


        public SelectOctopusPage NavigateToDefaultPage()
        {
            if (Driver.Url != PageAddress)
            {
                Driver.Url = PageAddress;
            }
            return this;

        }


        public SelectOctopusPage SeaFoodClick()
        {
            _seaFood.Click();
            return this;
        }


        public SelectOctopusPage Octopus()
        {
            _octopus.Click();

            return this;
        }



        public SelectOctopusPage ResultOfSearch()
        {
            Assert.AreEqual("Aštuonkojai", "Aštuonkojai");
            return this;

        }
    }
}
