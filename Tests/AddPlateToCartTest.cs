using NUnit.Framework;

namespace Baigiamasis_Projektas.Tests
{
    internal class AddPlateToCartTest : BaseTest
    {
        [Test]
        public static void AddItemToCart()

        {
            _ = _addItemToCartPage.NavigateToDefaultPage();
            _ = _addItemToCartPage.AgePopUpAgree();
            _ = _addItemToCartPage.ChosePlate();
            _ = _addItemToCartPage.AddPlateToCart();
            _ = _addItemToCartPage.OpenCart();

            //Without items cart is not opening.
        }
    }
}
