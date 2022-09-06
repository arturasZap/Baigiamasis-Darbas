using NUnit.Framework;
using OpenQA.Selenium;

namespace Baigiamasis_Projektas.Pages
{
    internal class wrongLoginPage : BasePage

    {
        public wrongLoginPage(IWebDriver webDriver) : base(webDriver) { }


        private const string PageAddress = "https://www.astuonkojis.lt/";

        private IWebElement _popUpAge => Driver.FindElement(By.CssSelector("#age-verification > a.button.yes.fl"));

        private IWebElement _loginLogo => Driver.FindElement(By.CssSelector("#login_fly_on"));

        private IWebElement _emailInputField => Driver.FindElement(By.CssSelector("#login_form_modal > div > div > div:nth-child(1) > input"));

        private IWebElement _paswordInputField => Driver.FindElement(By.XPath("//*[@id=\"login_form_modal\"]/div/div/div[2]/input"));

        private IWebElement _submitButton => Driver.FindElement(By.CssSelector("#login_form_modal > div > div > a.reg-btn.fl.btn1.submit-button.a0.mt15"));

        private IWebElement _errorMessage => Driver.FindElement(By.LinkText("Neteisingai įvestas vartotojo vardas arba slaptažodis!\r\n"));




        public wrongLoginPage AgePopUpAgree()

        {
            _popUpAge.Click();

            return this;

        }

        public wrongLoginPage LoginLogoClick()

        {

            _loginLogo.Click();

            return this;
        }

        public wrongLoginPage EmailInputField(string email)

        {
            _emailInputField.Clear();
            _emailInputField.SendKeys(email);

            return this;
        }

        public wrongLoginPage PaswordInputField(string pasword)

        {
            _paswordInputField.Clear();
            _paswordInputField.SendKeys(pasword);

            return this;
        }
        public wrongLoginPage ClickSubmitButton()

        {
            _submitButton.Click();

            return this;
        }
        public wrongLoginPage LoginErrorShown()

        {
            Assert.AreEqual(_errorMessage, "Neteisingai įvestas vartotojo vardas arba slaptažodis!", "Error?");

            return this;
        }

        public wrongLoginPage NavigateToDefaultPage()
        {
            if (Driver.Url != PageAddress)
            {
                Driver.Url = PageAddress;
            }
            return this;

        }

    }

}
