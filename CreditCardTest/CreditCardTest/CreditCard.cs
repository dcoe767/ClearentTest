using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardTest
{
    public class CreditCard
    {
        protected double _Balance;
        protected double _InterestRate;
        protected IInterestCalculator _Calc;
        protected string _Company;

        public CreditCard()
        {

        }

        public double InterestDue() { return _Calc.InterestDue(_Balance, _InterestRate); }
        public double InterestRate { get; set; }
        public double Balance { get; set; }
        public string Company { get { return _Company; } }
        
    }
}
