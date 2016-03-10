using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CreditCardTest;
using System.Collections.Generic;
using System.Linq;

namespace InterestCalculationTests
{
    [TestClass]
    public class TestCase3
    {
        //Build the objects for the test..........
        Person TestPerson1 = new Person();
        Person TestPerson2 = new Person();
        Wallet TestWallet1 = new Wallet();
        Wallet TestWallet2 = new Wallet();
        VisaCard VC = new VisaCard(new SimpleInterestCalculator(), .10, 100.00);
        MasterCard MC = new MasterCard(new SimpleInterestCalculator(), .05, 100);
        DiscoverCard DC = new DiscoverCard(new SimpleInterestCalculator(), .01, 100);

        [TestInitialize]
        public void TestInit()
        {
            TestWallet1.AddCard(VC);
            TestWallet1.AddCard(MC);
            TestWallet1.AddCard(DC);
            TestWallet2.AddCard(VC);
            TestWallet2.AddCard(MC);
            TestPerson1.Wallets.Add(TestWallet1);
            TestPerson2.Wallets.Add(TestWallet2);
        }

        [TestCleanup]
        public void CleanUp()
        {
            VC = null;
            DC = null;
            MC = null;
            TestWallet1 = null;
            TestWallet2 = null;
            TestPerson1 = null;
            TestPerson2 = null;
        }

        [TestMethod]
        public void Test3Person1Interest()
        {

            //Calc Total interest for the person...  should be 16.00....

            double totalInterest = 0.0;

            foreach (Wallet w in TestPerson1.Wallets)
            {
                foreach (CreditCard c in w.Cards)
                {
                    totalInterest += c.InterestDue();
                }
            }

            Assert.AreEqual(totalInterest, 16.00);
        }


        [TestMethod]
        public void Test3Person2Interest()
        {

            //Calc Total interest for the person...  should be 16.00....

            double totalInterest = 0.0;

            foreach (Wallet w in TestPerson2.Wallets)
            {
                foreach (CreditCard c in w.Cards)
                {
                    totalInterest += c.InterestDue();
                }
            }

            Assert.AreEqual(totalInterest, 15.00);
        }

        [TestMethod]
        public void Test3InterestWallet1()
        {
            double totalInterest = 0.0;

            Wallet wallet1 = TestPerson1.Wallets[0];
            foreach (CreditCard c in wallet1.Cards)
            {
                totalInterest += c.InterestDue();
            }

            Assert.AreEqual((16.00), totalInterest);
        }

        [TestMethod]
        public void Test3InterestWallet2()
        {
            double totalInterest = 0.0;

            Wallet wallet1 = TestPerson2.Wallets[0];
            foreach (CreditCard c in wallet1.Cards)
            {
                totalInterest += c.InterestDue();
            }

            Assert.AreEqual((15.00), totalInterest);
        }
    }
}
