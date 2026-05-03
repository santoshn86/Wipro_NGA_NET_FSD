using System;
using System.Collections.Generic;
using System.Text;

namespace Day_5_Practice_Assignment
{
    namespace BankingTransactionSystem
    {
        // ==========================================
        // Custom Exception 1
        // ==========================================
        public class InsufficientBalanceException : Exception
        {
            public InsufficientBalanceException(string message)
                : base(message)
            {
            }
        }

        // ==========================================
        // Custom Exception 2
        // ==========================================
        public class InvalidAmountException : Exception
        {
            public InvalidAmountException(string message)
                : base(message)
            {
            }
        }

        // ==========================================
        // Bank Account Class
        // ==========================================
        public class BankAccount
        {
            public string AccountHolderName { get; set; }
            public double Balance { get; private set; }

            private const double MIN_BALANCE = 1000;

            // Constructor
            public BankAccount(string name, double initialBalance)
            {
                if (initialBalance < MIN_BALANCE)
                {
                    throw new ArgumentException(
                        $"Initial balance must be at least ₹{MIN_BALANCE}");
                }

                AccountHolderName = name;
                Balance = initialBalance;
            }

            // ==========================================
            // Deposit Method
            // ==========================================
            public void Deposit(double amount)
            {
                if (amount <= 0)
                {
                    throw new InvalidAmountException(
                        "Deposit amount must be greater than zero.");
                }

                Balance += amount;

                Console.WriteLine(
                    $"₹{amount} deposited successfully.");
            }

            // ==========================================
            // Withdraw Method
            // ==========================================
            public void Withdraw(double amount)
            {
                if (amount <= 0)
                {
                    throw new InvalidAmountException(
                        "Withdrawal amount must be greater than zero.");
                }

                if (amount > Balance)
                {
                    throw new InsufficientBalanceException(
                        "Withdrawal amount exceeds current balance.");
                }

                if ((Balance - amount) < MIN_BALANCE)
                {
                    throw new InsufficientBalanceException(
                        $"Minimum balance of ₹{MIN_BALANCE} must be maintained.");
                }

                Balance -= amount;

                Console.WriteLine(
                    $"₹{amount} withdrawn successfully.");
            }

            // ==========================================
            // Check Balance
            // ==========================================
            public void CheckBalance()
            {
                Console.WriteLine(
                    $"Current Balance: ₹{Balance}");
            }
        }

    }
}
