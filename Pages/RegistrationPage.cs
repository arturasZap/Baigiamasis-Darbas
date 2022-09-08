using NUnit.Framework;
using OpenQA.Selenium;

namespace Baigiamasis_Projektas.Pages
{
    internal class RegistrationPage : BasePage

    {


        public RegistrationPage(IWebDriver webDriver) : base(webDriver) { }




        private const string PageAddress = "https://www.astuonkojis.lt/registracija";

        private IWebElement _popUpAge => Driver.FindElement(By.CssSelector("#age-verification > a.button.yes.fl"));

        private IWebElement _emailFieldInput => Driver.FindElement(By.CssSelector("#physical_email"));

        private IWebElement _nameFieldInput => Driver.FindElement(By.Id("physical_name"));

        private IWebElement _paswordInputField => Driver.FindElement(By.Id("physical_password"));

        private IWebElement _paswordRepeatField => Driver.FindElement(By.Id("physical_repeat_password"));

        private IWebElement _rulesCheckBox => Driver.FindElement(By.CssSelector("#physical_terms"));

        private IWebElement _clickSubmitButton => Driver.FindElement(By.XPath("//*[@id=\"physical_register_form\"]/div[3]/a"));

        private IWebElement _resultCheck => Driver.FindElement(By.CssSelector("#middle_content > h2"));





        public RegistrationPage AgePopUpAgree()

        {
            _popUpAge.Click();

            return this;

        }

        public RegistrationPage EmailInputField(string email)

        {
            _emailFieldInput.Clear();
            _emailFieldInput.SendKeys(email);

            return this;
        }

        public RegistrationPage NameInputField(string name)

        {
            _nameFieldInput.Clear();
            _nameFieldInput.SendKeys(name);

            return this;
        }

        public RegistrationPage PaswordInput(string pasword)

        {
            _paswordInputField.Clear();
            _paswordInputField.SendKeys(pasword);

            return this;
        }

        public RegistrationPage PaswordRepeat(string paswordR)

        {
            _paswordRepeatField.Clear();
            _paswordRepeatField.SendKeys(paswordR);

            return this;
        }

        public RegistrationPage ClickCheckBox()

        {

            _ = ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].click();", _rulesCheckBox);
            return this;


        }

        public RegistrationPage ClickSubmitButton()

        {

            _ = ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].click();", _clickSubmitButton);
            return this;
        }

        public RegistrationPage ResultCheck()

        {
            Assert.That("Jūsų registracija sėkminga", Is.EqualTo("Jūsų registracija sėkminga"));

            return this;
        }

        public RegistrationPage NavigateToDefaultPage()
        {
            if (Driver.Url != PageAddress)
            {
                Driver.Url = PageAddress;
            }
            return this;

        }

    }
}
