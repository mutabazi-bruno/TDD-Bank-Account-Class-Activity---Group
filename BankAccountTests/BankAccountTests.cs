using NUnit.Framework;
using BankAccountLib;

namespace BankAccountTests
{
    [TestFixture]
    public class BankAccountTests
    {
        private BankAccount _account;

        [SetUp]
        public void SetUp()
        {
            // Create a fresh account before each test
            _account = new BankAccount();
        }

        // ===== TEST 1: New account should have zero balance =====
        [Test]
        public void NewAccount_ShouldHaveZeroBalance()
        {
            Assert.That(_account.GetBalance(), Is.EqualTo(0m));
        }

        // ===== TEST 2: Deposit should increase the balance =====
        [Test]
        public void Deposit_ValidAmount_ShouldIncreaseBalance()
        {
            _account.Deposit(100m);
            Assert.That(_account.GetBalance(), Is.EqualTo(100m));
        }

        // ===== TEST 3: Multiple deposits should accumulate =====
        [Test]
        public void Deposit_MultipleTimes_ShouldAccumulateBalance()
        {
            _account.Deposit(50m);
            _account.Deposit(30m);
            Assert.That(_account.GetBalance(), Is.EqualTo(80m));
        }

        // ===== TEST 4: Negative deposit should throw exception =====
        [Test]
        public void Deposit_NegativeAmount_ShouldThrowException()
        {
            Assert.Throws<ArgumentException>(() => _account.Deposit(-50m));
        }

        // ===== TEST 5: Zero deposit should throw exception =====
        [Test]
        public void Deposit_ZeroAmount_ShouldThrowException()
        {
            Assert.Throws<ArgumentException>(() => _account.Deposit(0m));
        }

        // ===== TEST 6: Withdraw should decrease the balance =====
        [Test]
        public void Withdraw_ValidAmount_ShouldDecreaseBalance()
        {
            _account.Deposit(200m);
            _account.Withdraw(50m);
            Assert.That(_account.GetBalance(), Is.EqualTo(150m));
        }

        // ===== TEST 7: Negative withdrawal should throw exception =====
        [Test]
        public void Withdraw_NegativeAmount_ShouldThrowException()
        {
            Assert.Throws<ArgumentException>(() => _account.Withdraw(-30m));
        }

        // ===== TEST 8: Zero withdrawal should throw exception =====
        [Test]
        public void Withdraw_ZeroAmount_ShouldThrowException()
        {
            Assert.Throws<ArgumentException>(() => _account.Withdraw(0m));
        }

        // ===== TEST 9: Overdraft should throw exception =====
        [Test]
        public void Withdraw_MoreThanBalance_ShouldThrowException()
        {
            _account.Deposit(100m);
            Assert.Throws<InvalidOperationException>(() => _account.Withdraw(150m));
        }

        // ===== TEST 10: Withdraw exact balance should leave zero =====
        [Test]
        public void Withdraw_ExactBalance_ShouldLeaveZeroBalance()
        {
            _account.Deposit(100m);
            _account.Withdraw(100m);
            Assert.That(_account.GetBalance(), Is.EqualTo(0m));
        }
    }
}
