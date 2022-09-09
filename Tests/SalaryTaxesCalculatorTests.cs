using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final.Tests
{
    class SalaryTaxesCalculatorTests : BaseTest
    {
        [Test]
        public static void TestWhatIsTotalWorkplaceCostWhereNetSalaryNpdBySelf()
        {
            _salaryTaxesCalculatorPage.NavigateToDefaultPage()
                .SelectSalaryByValue("i_rankas")
                .InsertAmount("5000")
                .SelectNpdCalculationType("pats")
                .InsertNpdAmount("500")
                .TickPensionCheckbox()
                .CheckWhatIsTotalWorkPlaceCost("8650,78EUR");
        }


        [Test]
        public static void TestWhatIsNetSalaryWhereSalaryGrossNpdCalculatedWithChildrenMarried()
        {
            _salaryTaxesCalculatorPage.NavigateToDefaultPage()
                 .SelectSalaryByValue("ant_popieriaus")
                 .InsertAmount("5000")
                 .SelectNpdCalculationType("auto")
                 .SelectChildrenByValue("5")
                 .SelectMarriageByValue("2")
                 .TickPensionCheckbox()
                 .CheckWhatIsNetSalary("3745,00EUR");

        }
    }
}
