﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CreditCardTest;
using System.Collections.Generic;
using System.Linq;

namespace InterestCalculationTests
{
    [TestClass]
    public class TestCase2
    {
        //Build the objects for the test..........
        Person TestPerson = new Person();
        Wallet TestWallet1 = new Wallet();
        Wallet TestWallet2 = new Wallet();
        VisaCard Card1 = new VisaCard(new SimpleInterestCalculator(), .10, 100.00);
        MasterCard MC = new MasterCard(new SimpleInterestCalculator(), .05, 100);
        DiscoverCard DC = new DiscoverCard(new SimpleInterestCalculator(), .01, 100);

        [TestInitialize]
        public void TestInit()
        {
            TestWallet1.AddCard(Card1);
            TestWallet2.AddCard(MC);
            TestWallet1.AddCard(DC);
            TestPerson.Wallets.Add(TestWallet1);
            TestPerson.Wallets.Add(TestWallet2);
        }


        [TestCleanup]
        public void CleanUp()
        {
            Card1 = null;
            DC = null;
            MC = null;
            TestWallet1 = null;
            TestWallet2 = null;
            TestPerson = null;
        }

        [TestMethod]
        public void Test2PersonInterest()
        {

            //Calc Total interest for the person...  should be 16.00....

            double totalInterest = 0.0;

            foreach (Wallet w in TestPerson.Wallets)
            {
                foreach (CreditCard c in w.Cards)
                {
                    totalInterest += c.InterestDue();
                }
            }

            Assert.AreEqual(totalInterest, 16.00);
        }

        [TestMethod]
        public void Test2InterestWallet1()
        {
            double totalInterest = 0.0;

            Wallet wallet1 = TestPerson.Wallets[0];
            foreach (CreditCard c in wallet1.Cards)
            {
                totalInterest += c.InterestDue();
            }

            Assert.AreEqual((11.00), totalInterest);
        }

        [TestMethod]
        public void Test2InterestWallet2()
        {
            double totalInterest = 0.0;

            Wallet wallet1 = TestPerson.Wallets[1];
            foreach (CreditCard c in wallet1.Cards)
            {
                totalInterest += c.InterestDue();
            }

            Assert.AreEqual((5.00), totalInterest);
        }
    }
}
