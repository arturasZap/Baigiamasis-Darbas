using OpenQA.Selenium;
using System.Threading;

namespace Baigiamasis_Projektas.Pages
{
    internal class WrongLoginPage : BasePage

    {
        public WrongLoginPage(IWebDriver webDriver) : base(webDriver) { }


        private const string PageAddress = "https://www.astuonkojis.lt/";

        private IWebElement _popUpAge => Driver.FindElement(By.CssSelector("#age-verification > a.button.yes.fl"));

        private IWebElement _loginLogo => Driver.FindElement(By.Id("login_fly_on"));

        private IWebElement _emailInputField => Driver.FindElement(By.CssSelector("#login_form_modal > div > div > div:nth-child(1) > input"));

        private IWebElement _paswordInputField => Driver.FindElement(By.XPath("//*[@id=\"login_form_modal\"]/div/div/div[2]/input"));

        private IWebElement _submitButton => Driver.FindElement(By.CssSelector("#login_form_modal > div > div > a.reg-btn.fl.btn1.submit-button.a0.mt15"));




        public WrongLoginPage AgePopUpAgree()

        {
            _popUpAge.Click();

            return this;

        }

        public WrongLoginPage LoginLogoClick()
        {
            Thread.Sleep(1000);
            _ = ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].click();", _loginLogo);
            return this;
        }



        public WrongLoginPage EmailInputField(string email)

        {
            _emailInputField.Clear();
            _emailInputField.SendKeys(email);

            return this;
        }

        public WrongLoginPage PaswordInputField(string pasword)

        {
            _paswordInputField.Clear();
            _paswordInputField.SendKeys(pasword);

            return this;
        }
        public WrongLoginPage ClickSubmitButton()

        {
            _submitButton.Click();

            return this;
        }


        public WrongLoginPage NavigateToDefaultPage()
        {
            if (Driver.Url != PageAddress)
            {
                Driver.Url = PageAddress;
            }
            return this;

        }

    }

}
