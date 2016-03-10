using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardTest
{
    public class SimpleInterestCalculator : IInterestCalculator
    {
        public SimpleInterestCalculator()
        {
        }

        public double InterestDue(double balance, double interestRate)
        {
            return balance * interestRate;
        }

    }
}
