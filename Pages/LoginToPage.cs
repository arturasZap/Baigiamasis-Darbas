using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;

namespace Baigiamasis_Projektas.Pages
{
    internal class LoginToPage : BasePage
    {


        public LoginToPage(IWebDriver webDriver) : base(webDriver) { }


        private const string PageAddress = "https://www.astuonkojis.lt/";

        private IWebElement _popUpAge => Driver.FindElement(By.CssSelector("#age-verification > a.button.yes.fl"));

        private IWebElement _loginLogo => Driver.FindElement(By.Id("login_fly_on"));

        private IWebElement _emailInputField => Driver.FindElement(By.CssSelector("#login_form_modal > div > div > div:nth-child(1) > input"));

        private IWebElement _paswordInputField => Driver.FindElement(By.CssSelector("#login_form_modal > div > div > div:nth-child(2) > input"));

        private IWebElement _loginButton => Driver.FindElement(By.CssSelector("#login_form_modal > div > div > a.reg-btn.fl.btn1.submit-button.a0.mt15"));

        private IWebElement _findAccountId => Driver.FindElement(By.Id("account_on"));


        public LoginToPage AgePopUpAgree()

        {
            _popUpAge.Click();

            return this;

        }

        public LoginToPage ClickOnLoginLogo()


        {
            Thread.Sleep(1500);
            _ = ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].click();", _loginLogo);
            return this;
        }

        public LoginToPage EmailInput(string email)

        {
            _emailInputField.Clear();
            _emailInputField.SendKeys(email);

            return this;
        }

        public LoginToPage PaswordInput(string pasword)

        {
            _paswordInputField.Clear();
            _paswordInputField.SendKeys(pasword);

            return this;
        }

        public LoginToPage ClickLoginButton()

        {
            _loginButton.Click();

            return this;
        }

        public LoginToPage FindAcount()

        {
            Assert.That(_findAccountId, Is.EqualTo(_findAccountId));

            return this;
        }

        public LoginToPage NavigateToDefaultPage()
        {
            if (Driver.Url != PageAddress)
            {
                Driver.Url = PageAddress;
            }
            return this;

        }

    }
}
