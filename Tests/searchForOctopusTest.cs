using NUnit.Framework;

namespace Baigiamasis_Projektas.Tests
{
    internal class SearchForOctopusTest : BaseTest
    {

        [Test]
        public static void testingSearch()

        {
            _ = _selectPage.NavigateToDefaultPage();
            _ = _selectPage.AgePopUpAgree();
            _ = _selectPage.SeaFoodClick();
            _ = _selectPage.Octopus();
            _ = _selectPage.ResultOfSearch();

        }

    }
}
