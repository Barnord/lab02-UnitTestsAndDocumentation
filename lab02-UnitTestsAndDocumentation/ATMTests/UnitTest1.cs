using System;
using ATM;
using Xunit;

// Tests in this namespace are designed to be run seperately, and some may not work if run on together.

namespace ATMTests
{
    public class UnitTest1
    {
        [Fact]
        public void ViewProperBalance()
        {
            Assert.Equal(Program.Balance, Program.ViewBalance());
        }

        [Fact]

        public void WithdrawInteger()
        {
            Assert.Equal(50, Program.Withdraw(50));
        }

        [Fact]

        public void WithdrawDecimal()
        {
            Assert.Equal(98.9M, Program.Withdraw(1.1M));
        }

        [Fact]
        public void DepositInteger()
        {
            Assert.Equal(150, Program.Deposit(50));
        }

        [Fact]

        public void DepositDecimal()
        {
            Assert.Equal(101.1M, Program.Deposit(1.1M));
        }
    }
}
