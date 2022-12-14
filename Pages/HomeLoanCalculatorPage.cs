using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace final.Pages
{
    class HomeLoanCalculatorPage : BasePage
    {
        private const string PageAddress = "https://www.bankai.lt/paskolos/busto-paskolos-skaiciuokle";

        private IWebElement _bannerClose => Driver.FindElement(By.CssSelector("#cbb > svg > path"));
        private IWebElement _creditSumInput => Driver.FindElement(By.Id("counter_suma"));
        private IWebElement _interestInput1 => Driver.FindElement(By.Id("counter_palukanos_a"));
        private IWebElement _creditType1 => Driver.FindElement(By.Id("s2id_ee1"));
        private IWebElement _anuitetas1 => Driver.FindElement(By.CssSelector("#select2-results-1 > li:nth-child(2)"));
        private IWebElement _interestInput2 => Driver.FindElement(By.Id("counter_palukanos_b"));
        private IWebElement _periodInput => Driver.FindElement(By.Id("counter_terminas"));
        private IWebElement _delayInput => Driver.FindElement(By.Id("counter_atidejimas"));
        private IWebElement _calculateButton => Driver.FindElement(By.CssSelector(".paskolos-skaiciuokle > div.mygtukas.dangus.large > a"));
        private IWebElement _resultSumWithInterests1 =>Driver.FindElement(By.CssSelector("#content > div > div > div > div.w1000 > div.paskolos-skaiciuokle-rezultatai > div.variantai > div:nth-child(1) > div > div:nth-child(8) > div > span.rSa"));
        private IWebElement _resultSumWithInterests2 => Driver.FindElement(By.CssSelector("#content > div > div > div > div.w1000 > div.paskolos-skaiciuokle-rezultatai > div.variantai > div.variantas.dashed > div > div:nth-child(8) > div > span.rSb"));
        public HomeLoanCalculatorPage(IWebDriver webDriver) : base(webDriver) { }

        public HomeLoanCalculatorPage NavigateToDefaultPage()
        {
            if (Driver.Url != PageAddress)
            {
                Driver.Url = PageAddress;
                
            }

            return this;
        }

        public HomeLoanCalculatorPage ClickBannerCloseInIframe()
        {
            GetWait(5);
            Driver.SwitchTo().Frame(0);
            _bannerClose.Click();
            Driver.SwitchTo().DefaultContent();
            ScrollDown();

            return this;
        }

        public HomeLoanCalculatorPage InsertCreditSum(string creditSum)
        {
            _creditSumInput.Clear();
            _creditSumInput.SendKeys(creditSum);

            return this;
        }

        public HomeLoanCalculatorPage InsertInterest1(string interest1)
        {
            _interestInput1.Clear();
            _interestInput1.SendKeys(interest1);

            return this;
        }

        public HomeLoanCalculatorPage ClickCreditType1()
        {
            _creditType1.Click();

            return this;
        }

        public HomeLoanCalculatorPage ClickAnuitetas1()
        {
            _anuitetas1.Click();

            return this;
        }

        public HomeLoanCalculatorPage InsertInterest2(string interest2)
        {
            _interestInput2.Clear();
            _interestInput2.SendKeys(interest2);

            return this;
        }

        public HomeLoanCalculatorPage InsertPeriod(string period)
        {
            _periodInput.Clear();
            _periodInput.SendKeys(period);

            return this;
        }

        public HomeLoanCalculatorPage InsertDelay(string delay)
        {
            _delayInput.Clear();
            _delayInput.SendKeys(delay);

            return this;
        }

        public HomeLoanCalculatorPage ClickCalculateButton()
        {
            _calculateButton.Click();
            Thread.Sleep(1000);
                                   
            return this;
        }

        public HomeLoanCalculatorPage CheckWhatSumWithInterestsIcanGet1(string expectedLoanAmount1)
        {
            Console.WriteLine(expectedLoanAmount1);
            string possibleLoanValue1 = _resultSumWithInterests1.Text.Trim().Replace(" ", "");
            Console.WriteLine(possibleLoanValue1);
            Assert.IsTrue(expectedLoanAmount1 == possibleLoanValue1, "Incorrect amount!");
            
            return this;
        }

        public HomeLoanCalculatorPage CheckWhatSumWithInterestsIcanGet2(string expectedLoanAmount2)
        {
            string possibleLoanValue2 = _resultSumWithInterests2.Text.Trim().Replace(" ", "");
            Assert.IsTrue(expectedLoanAmount2 == possibleLoanValue2, "Incorrect amount!");

            return this;
        }
    }
}

        