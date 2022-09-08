using OpenQA.Selenium;

namespace Baigiamasis_Projektas.Pages
{
    internal class AddItemToCartPage : BasePage
    {
        public AddItemToCartPage(IWebDriver webDriver) : base(webDriver) { }




        private const string PageAddress = "https://www.astuonkojis.lt/kitos_prekes";

        private IWebElement _popUpAge => Driver.FindElement(By.CssSelector("#age-verification > a.button.yes.fl"));

        private IWebElement _chosePlate => Driver.FindElement(By.CssSelector("#middle_blocks > li > div.product-list.flex > div.grid_8.flex-item.product.product-simple.product-229.item_hover_wrap_229.omega.item-line-last.hover-item.cp.mb10.item.zi1.product-item.item-list > div > div > div.vv > div > a"));

        private IWebElement _addItemToCart => Driver.FindElement(By.CssSelector("#addButton229 > form > a"));

        private IWebElement _openCart => Driver.FindElement(By.Id("cart-link"));








        public AddItemToCartPage AgePopUpAgree()

        {
            _popUpAge.Click();

            return this;

        }

        public AddItemToCartPage ChosePlate()

        {
            _chosePlate.Click();

            return this;
        }


        public AddItemToCartPage AddPlateToCart()

        {

            _ = ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].click();", _addItemToCart);
            return this;
        }

        public AddItemToCartPage OpenCart()

        {

            _ = ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].click();", _openCart);
            return this;
        }




        public AddItemToCartPage NavigateToDefaultPage()
        {
            if (Driver.Url != PageAddress)
            {
                Driver.Url = PageAddress;
            }
            return this;

        }

    }
}
