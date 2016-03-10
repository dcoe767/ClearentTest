using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardTest
{
    public class Wallet
    {
        private List<CreditCard> _Cards;
        public Wallet()
        {
            _Cards = new List<CreditCard>();
        }    
    
        public void AddCard(CreditCard CardToAdd)
        {
            _Cards.Add(CardToAdd);
        }

        public List<CreditCard> Cards
        {
            get
            {
                return _Cards;
            }
        }

    }
}
