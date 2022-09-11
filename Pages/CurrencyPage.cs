using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace final.Pages
{
    class CurrencyPage : BasePage
    {
        private const string PageAddress = "https://www.bankai.lt/valiutos/valiutu-skaiciuokle";

        private IWebElement _bannerClose => Driver.FindElement(By.CssSelector("#cbb > svg > path"));
        private IWebElement _wantToBuyCheckbox => Driver.FindElement(By.CssSelector(".valiutos-tipas > a:nth-child(3) > div"));
        private IWebElement _currencyAmountInput => Driver.FindElement(By.Id("valiutos_suma"));
        private IWebElement _currencyDropdown => Driver.FindElement(By.Id("s2id_ee1"));
        private IWebElement _mauricijausRupija => Driver.FindElement(By.Id("select2-result-label-53"));
        private IWebElement _calculateButton => Driver.FindElement(By.CssSelector(".valiutu-skaiciuokle > .mygtukas > a"));
        private IWebElement _resultSellingFor => Driver.FindElement(By.CssSelector("#content > div > div > div > div.w1000 > div.infobox > div > div > div.slinktiBox > div.slinktiBoxContent.ln-valiutos-skaiciuokle > div.z1box > div.valiutos-skaiciuokle-box.gryni-box.hoverable > div:nth-child(1) > div.t.fr.bl.sgln.s18.bgd.tc.rc--2.col1.gryni.bgy > span"));
        public CurrencyPage(IWebDriver webDriver) : base(webDriver) { }

        public CurrencyPage NavigateToDefaultPage()
        {
            if (Driver.Url != PageAddress)
            {
                Driver.Url = PageAddress;
                
            }

            return this;
        }

        public CurrencyPage ClickBannerCloseInIframe()
        {
            GetWait(5);
            Driver.SwitchTo().Frame(0);
            _bannerClose.Click();
            Driver.SwitchTo().DefaultContent();
            ScrollDown();

            return this;
        }
             

        public CurrencyPage TickWantToBuyCheckbox()
        {
            _wantToBuyCheckbox.Click();
            Thread.Sleep(200);


            return this;
        }

        public CurrencyPage InsertCurrencyAmount(string currencyAmount)
        {
            _currencyAmountInput.Clear();
            _currencyAmountInput.SendKeys(currencyAmount);

            return this;
        }

        public CurrencyPage ClickCurrencyDropdown()
        {
            _currencyDropdown.Click();

            return this;
        }

        public CurrencyPage ClickMauricijausRupija()
        {
            _mauricijausRupija.Click();

            return this;
        }

       
        public CurrencyPage ClickCalculateButton()
        {
            Thread.Sleep(2000);
            _calculateButton.Click();
            Thread.Sleep(4000);

            return this;
        }

        public CurrencyPage CheckWhatIsTheAmountToBuy(string expectedAmount)
        {
            Console.WriteLine(expectedAmount);
            string sellingFor = _resultSellingFor.Text.Trim().Replace(" ", "");
            Console.WriteLine(sellingFor);
            Assert.IsTrue(expectedAmount == sellingFor, "Incorrect amount!");

            return this;
        }

    }
}
