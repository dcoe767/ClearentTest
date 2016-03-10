using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardTest
{
    public class VisaCard : CreditCard
    {
        
        public VisaCard(IInterestCalculator calc, double initialRate = 0.10, double initialBalance = 0.0)
        {
            _InterestRate = initialRate;
            _Balance = initialBalance;
            _Calc = calc;
            _Company = "Visa";
        }

        
    }
}
