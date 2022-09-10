using NUnit.Framework;

namespace Baigiamasis_Projektas.Tests
{
    internal class WrongEmailAndPaswordInputTest : BaseTest
    {
        [Test]

        public static void TestingWrongLoginCredits()

        {
            string email = "mail@what.com";
            string password = "mokausi";

            _ = _wrongLoginPage.NavigateToDefaultPage();
            _ = _wrongLoginPage.AgePopUpAgree();
            _ = _wrongLoginPage.LoginLogoClick();
            _ = _wrongLoginPage.EmailInputField(email);
            _ = _wrongLoginPage.PaswordInputField(password);
            _ = _wrongLoginPage.ClickSubmitButton();

        }
    }

}
