using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace final.Pages
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
            ((IJavaScriptExecutor)Driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight - 5000)");
        }

        public void CloseBrowser()
        {
            Driver.Quit();
        }
    }
}