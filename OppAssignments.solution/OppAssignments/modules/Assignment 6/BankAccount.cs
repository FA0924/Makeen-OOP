using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppAssignments.modules.Assignment_6
{
    public class BankAccount
    {
        // ----------------------- Static Field
        private static int totalAccounts = 0;

        // ----------------------- Private Fields (Encapsulation)
        private int accountNumber;
        private string owner;
        private decimal balance;

        // ----------------------- Constructor
        public BankAccount(int accountNumber, string owner, decimal initialBalance)
        {
            this.accountNumber = accountNumber;
            this.owner = owner;
            this.balance = initialBalance >= 0 ? initialBalance : 0;
            totalAccounts++;
            Console.WriteLine($"Account created successfully for {owner}");
        }

        // ----------------------- Public Properties with Validation
        public int AccountNumber
        {
            get { return this.accountNumber; }
            set { this.accountNumber = value; }
        }

        public string Owner
        {
            get { return this.owner; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("owner name cant be empty");
                }
                else
                {
                    this.owner = value;
                }
            }
        }

        public decimal Balance
        {
            get { return this.balance; }
            private set
            {
                if (value < 0)
                {
                    Console.WriteLine("balance cant be negative");
                }
                else
                {
                    this.balance = value;
                }
            }
        }

        // ----------------------- Deposit Method
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("invalid amount, please enter a positive value");
            }
            else
            {
                this.balance += amount;
                Console.WriteLine($"deposit successful! {amount:C} added to account");
                Console.WriteLine($"new balance: {this.balance:C}");
            }
        }

        // ----------------------- Withdraw Method
        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("invalid amount, please enter a positive value");
            }
            else if (amount > this.balance)
            {
                Console.WriteLine($"insufficient funds! ur current balance is {this.balance:C}");
            }
            else
            {
                this.balance -= amount;
                Console.WriteLine($"withdrawal successful! {amount:C} withdrawn from account");
                Console.WriteLine($"new balance: {this.balance:C}");
            }
        }

        // ----------------------- Display Account Info
        public void DisplayAccountInfo()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("ACCOUNT INFORMATION");
            Console.WriteLine($"Account Number: {this.accountNumber}");
            Console.WriteLine($"Owner: {this.owner}");
            Console.WriteLine($"Balance: {this.balance:C}");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
        }

        // ----------------------- Static Method
        public static void ShowTotalAccounts()
        {
            Console.WriteLine($"Total number of accounts created: {totalAccounts}");
        }
    }
}