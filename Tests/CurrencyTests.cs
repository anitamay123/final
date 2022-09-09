using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final.Tests
{
    class CurrencyTests : BaseTest
    {
        [Test]
        public static void TestCurrencyCalculatorToBuyMauricijausRupija()
        {
            _currencyPage.NavigateToDefaultPage()
                .TickWantToBuyCheckbox()
                .InsertCurrencyAmount("5000")
                .ClickCurrencyDropdown()
                .ClickMauricijausRupija()
                .ClickCalculateButton()
                .CheckWhatIsTheAmountToBuy("115,62EUR");
        }
    }
}
