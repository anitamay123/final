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
                .ClickBannerCloseInIframe()
                .TickWantToBuyCheckbox()
                .ClickBannerCloseInIframe()
                .InsertCurrencyAmount("5000")
                .ClickCurrencyDropdown()
                .ClickMauricijausRupija()
                /*.ClickBannerCloseInIframe() ne visada randa si baneri ir del to failina testas*/ 
                .ClickCalculateButton()
                .CheckWhatIsTheAmountToBuy("115,68EUR");
        }
    }
}
