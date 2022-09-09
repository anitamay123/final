using final.Drivers;
using final.Pages;
using final.Tools;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final.Tests
{
    class BaseTest
    {
        protected static IWebDriver Driver;

        public static CurrencyPage _currencyPage;
        public static HomeLoanCalculatorPage _homeLoanCalculatorPage;
        public static SalaryTaxesCalculatorPage _salaryTaxesCalculatorPage;


        [OneTimeSetUp]
        public static void SetUp()
        {
            Driver = CustomDriver.GetChromeDriver();

            _currencyPage = new CurrencyPage(Driver);
            _homeLoanCalculatorPage = new HomeLoanCalculatorPage(Driver);
            _salaryTaxesCalculatorPage = new SalaryTaxesCalculatorPage(Driver);

        }

        [TearDown]
        public static void TakeScreeshot()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
                MyScreenshot.MakeScreeshot(Driver);
        }

        [OneTimeTearDown]
        public static void TearDown()
        {
            Driver.Quit();
        }
    }
}