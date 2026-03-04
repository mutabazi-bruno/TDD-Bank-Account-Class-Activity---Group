using System;

namespace BankAccountLib
{
    public class BankAccount
    {
        private decimal _balance;

        public BankAccount()
        {
            _balance = 0m;
        }

        // Returns the current balance
        public decimal GetBalance()
        {
            return _balance;
        }

        // Deposits money into the account
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be positive.");
            }

            _balance += amount;
        }

        // Withdraws money from the account
        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Withdrawal amount must be positive.");
            }

            if (amount > _balance)
            {
                throw new InvalidOperationException("Insufficient funds. Cannot withdraw more than the current balance.");
            }

            _balance -= amount;
        }
    }
}
