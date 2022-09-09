using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final.Tests
{
    class HomeLoanCalculatorTests : BaseTest
    {
        [Test]
        public static void TestHomeLoanCalculatorSumWithInterests1()
        {
            _homeLoanCalculatorPage.NavigateToDefaultPage()
                .InsertCreditSum("150000")
                .InsertInterest1("2")
                .ClickCreditType1()
                .ClickAnuitetas1()
                .InsertInterest2("3")
                .InsertPeriod("25")
                .InsertDelay("6")
                .ClickCalculateButton()
                .CheckWhatSumWithInterestsIcanGet1("191361,80");
        }

        [Test]
        public static void TestHomeLoanCalculatorSumWithInterests2()
        {
            _homeLoanCalculatorPage.NavigateToDefaultPage()
                .InsertCreditSum("150000")
                .InsertInterest1("2")
                .ClickCreditType1()
                .ClickAnuitetas1()
                .InsertInterest2("3")
                .InsertPeriod("25")
                .InsertDelay("6")
                .ClickCalculateButton()
                .CheckWhatSumWithInterestsIcanGet2("214247,00");
        }

    }
}