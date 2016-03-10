using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardTest
{
    public interface IInterestCalculator
    {
        double InterestDue(double balance, double interestrate);
    }
}
