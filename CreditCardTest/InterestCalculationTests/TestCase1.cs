using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using CreditCardTest;
using System.Linq;

namespace InterestCalculationTests
{
    [TestClass]
    public class TestCase1
    {

        //Build the objects for the test..........
            Person TestPerson = new Person();
            Wallet TestWallet = new Wallet();
            VisaCard Card1 = new VisaCard(new SimpleInterestCalculator(), .10, 100.00);
            MasterCard MC = new MasterCard(new SimpleInterestCalculator(), .05, 100);
            DiscoverCard DC = new DiscoverCard(new SimpleInterestCalculator(), .01, 100);

        [TestInitialize]
        public void TestInit()
        {
            TestWallet.AddCard(Card1);
            TestWallet.AddCard(MC);
            TestWallet.AddCard(DC);
            TestPerson.Wallets.Add(TestWallet);
        }

        [TestCleanup]
        public void CleanUp()
        {
            Card1 = null;
            DC = null;
            MC = null;
            TestWallet = null;
            TestPerson = null;
        }

        [TestMethod]
        public void Test1PersonInterest()
        {
            
            //Calc Total interest for the person...  should be 16.00....

            double totalInterest = 0.0;

            foreach(Wallet w in TestPerson.Wallets)
            {
                foreach(CreditCard c in w.Cards)
                {
                    totalInterest += c.InterestDue();
                }
            }

            Assert.AreEqual(totalInterest, 16.00);
        }

        [TestMethod]
        public void Test1VisaCardInterestOK()
        {
            double totalInterest = 0.0;
            int NumberOfCards = 0;


            List<CreditCard> vc = new List<CreditCard>();



            foreach (Wallet w in TestPerson.Wallets)
            {
                vc = w.Cards.Where<CreditCard>(cc => cc.Company == "Visa").ToList<CreditCard>();
                NumberOfCards += vc.Count;
                foreach(CreditCard c in vc)
                {
                    totalInterest += c.InterestDue();
                }
            }

            Assert.AreEqual((10.00 * NumberOfCards), totalInterest);
        }

        [TestMethod]
        public void Test1DiscoverCardInterestOK()
        {
            double totalInterest = 0.0;
            int NumberOfCards = 0;


            List<CreditCard> vc = new List<CreditCard>();



            foreach (Wallet w in TestPerson.Wallets)
            {
                vc = w.Cards.Where<CreditCard>(cc => cc.Company == "Discover").ToList<CreditCard>();
                NumberOfCards += vc.Count;
                foreach (CreditCard c in vc)
                {
                    totalInterest += c.InterestDue();
                }
            }

            Assert.AreEqual((1.00 * NumberOfCards), totalInterest);
        }

        [TestMethod]
        public void Test1MasterCardInterestOK()
        {
            double totalInterest = 0.0;
            int NumberOfCards = 0;


            List<CreditCard> vc = new List<CreditCard>();



            foreach (Wallet w in TestPerson.Wallets)
            {
                vc = w.Cards.Where<CreditCard>(cc => cc.Company == "MasterCard").ToList<CreditCard>();
                NumberOfCards += vc.Count;
                foreach (CreditCard c in vc)
                {
                    totalInterest += c.InterestDue();
                }
            }

            Assert.AreEqual((5.00 * NumberOfCards), totalInterest);
        }

    }
}
