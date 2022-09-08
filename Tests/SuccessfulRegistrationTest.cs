using NUnit.Framework;

namespace Baigiamasis_Projektas.Tests
{
    internal class SuccessfulRegistrationTest : BaseTest
    {
        [Test]
        public static void RegistrationSuccess()

        {
            string name = "Baigiamasis";
            string email = "vilniuscodschool@gmail.com";
            string pasword = "pipirass";
            string paswordR = "pipirass";

            _ = _registrationPage.NavigateToDefaultPage();
            _ = _registrationPage.AgePopUpAgree();
            _ = _registrationPage.EmailInputField(email);
            _ = _registrationPage.NameInputField(name);
            _ = _registrationPage.PaswordInput(pasword);
            _ = _registrationPage.PaswordRepeat(paswordR);
            _ = _registrationPage.ClickCheckBox();
            _ = _registrationPage.ClickSubmitButton();
            _ = _registrationPage.ResultCheck();
        }
    }
}
