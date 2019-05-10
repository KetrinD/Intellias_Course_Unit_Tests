using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAccountNS;

namespace BankTest
{
    [TestClass]
    public class BankAccountTests_Credit
    {
        [TestMethod]
        public void Credit_WithValidAmount_UpdatesBalance()
        {
            // arrange
            double beginningBalance = 11.99;
            double creditAmount = 6.33;
            double expected = 18.32;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);
            // act
            account.Credit(creditAmount);
            // assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not credited correctly");
        }
    }
}
