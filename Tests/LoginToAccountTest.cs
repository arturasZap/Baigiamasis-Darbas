using NUnit.Framework;

namespace Baigiamasis_Projektas.Tests
{
    internal class LoginToAccountTest : BaseTest
    {
        [Test]
        public static void LoggingToAccount()

        {
            string email = "penkki@gmail.com";
            string password = "pipirass";



            _ = _loginToPage.NavigateToDefaultPage();
            _ = _loginToPage.AgePopUpAgree();
            _ = _loginToPage.ClickOnLoginLogo();
            _ = _loginToPage.EmailInput(email);
            _ = _loginToPage.PaswordInput(password);
            _ = _loginToPage.ClickLoginButton();
            _ = _loginToPage.FindAcount();

        }
    }
}
