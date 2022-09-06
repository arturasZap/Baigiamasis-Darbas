using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Baigiamasis_Projektas.Pages
{
    public class BasePage
    {
        protected static IWebDriver Driver;

        public BasePage(IWebDriver webDriver)
        {
            Driver = webDriver;
        }

        public WebDriverWait GetWait(int seconds = 5)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(seconds));
            return wait;
        }

        public void ScrollDown()
        {
            _ = ((IJavaScriptExecutor)Driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight + 150)");
        }

        public void CloseBrowser()
        {
            Driver.Quit();
        }
    }
}
