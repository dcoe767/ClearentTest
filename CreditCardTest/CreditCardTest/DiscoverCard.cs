using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardTest
{
    public class DiscoverCard : CreditCard
    {
        public DiscoverCard(IInterestCalculator calc, double initialRate = 0.01, double initialBalance = 0.0)
        {
            base._InterestRate = initialRate;
            base._Balance = initialBalance;
            base._Calc = calc;
            _Company = "Discover";
        }
    }
}
