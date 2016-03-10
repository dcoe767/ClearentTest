using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardTest
{
    public class Person
    {
        private List<Wallet> _Wallets;
       
        public Person()
        {
            _Wallets = new List<Wallet>();
        }

        public List<Wallet> Wallets
        {
            get { return _Wallets; }
            set { _Wallets = value; }
        }

        

    }
}
