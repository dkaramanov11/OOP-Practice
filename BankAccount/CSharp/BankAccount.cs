using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice.BankAccount.CSharp
{
    internal class BankAccount
    {
        public string AccountNumber { get; }
        public string OwnerName { get; }
        public decimal Balance { get; private set; }

        public BankAccount(string accountNumber, string ownerName, decimal initialBalance)
        {
            AccountNumber = accountNumber;
            OwnerName = ownerName;

            if (initialBalance < 0)
            {
                Console.WriteLine(
                    "Initial balance cannot be negative. Setting it to 0.");

                Balance = 0;
            }
            else
            {
                Balance = initialBalance;
            }
        }

        public void Deposit(decimal amount) 
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be greater than 0.");
                return;
            }

            Balance += amount;
            Console.WriteLine($"Deposited: {amount:F2}\n Balance: {Balance:F2}");
        }

        public void Withdraw(decimal amount) {

            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be greater than 0.");
                return;
            }

            if (amount > Balance)
            {
                Console.WriteLine("Insufficient funds.");
                return;
            }

            Balance -= amount;
            Console.WriteLine($"Withdrawn: {amount:F2}\n Balance: {Balance:F2}");
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Account number: {AccountNumber}");
            Console.WriteLine($"Owner: {OwnerName}");
            Console.WriteLine($"Balance: {Balance:F2}");
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(
                 "123456789",
                 "Daniel Karamanov",
                 1000m);

            account.PrintInfo();

            Console.WriteLine();


            account.Deposit(500m);    // Balance: 1500
            account.Withdraw(300m);   // Balance: 1200
            account.Withdraw(2000m);  // Insufficient funds

            account.Deposit(0m);     // Invalid deposit
            account.Withdraw(-50m);  // Invalid withdrawal


            Console.WriteLine();
            account.PrintInfo();

            Console.WriteLine("\nTesting a negative initial balance:");

            BankAccount secondAccount = new BankAccount(
                "987654321",
                "Test Owner",
                -100m);

            secondAccount.PrintInfo();
        }
    }

}
