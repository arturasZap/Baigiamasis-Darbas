using NUnit.Framework;

namespace Baigiamasis_Projektas.Tests
{
    internal class wrongEmailAndPaswordInputTest : BaseTest
    {
        [Test]

        public static void TestingWrongLoginCredits()

        {
            string email = "vcs@mokausi.lt";
            string password = "astuonkojis";

            _ = _wrongLoginPage.NavigateToDefaultPage();
            _ = _wrongLoginPage.AgePopUpAgree();
            _ = _wrongLoginPage.LoginLogoClick();
            _ = _wrongLoginPage.EmailInputField(email);
            _ = _wrongLoginPage.PaswordInputField(password);
            _ = _wrongLoginPage.ClickSubmitButton();
            _ = _wrongLoginPage.LoginErrorShown();
        }
    }

}
