using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay2ComplexClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer cust = new Customer
            {
                FirstName = "Alice",
                CheckingAccount =
                {
                    Amount = 100m,
                    IsOpen = true,
                    Id = 1,
                    Type = AccountType.Checking
                },
                SavingsAccount =
                {
                    IsOpen = false,
                    Id = 2,
                    Type = AccountType.Savings
                }
            };
            
            cust.Transfer(50m, AccountType.Checking, AccountType.Savings);

            Console.WriteLine(cust.CheckingAccount.Amount);
            Console.WriteLine(cust.SavingsAccount.Amount);

            Console.ReadLine();
        }
    }

    class Account
    {
        public int Id { get; set; }
        public AccountType Type { get; set; }
        public decimal Amount { get; set; }
        public bool IsOpen { get; set; }
    }

    enum AccountType
    {
        Checking,
        Savings
    }

    class Customer
    {
        public Customer()
        {
            CheckingAccount = new Account();
            SavingsAccount = new Account();
        }

        public string FirstName { get; set; }
        public Account CheckingAccount { get; set; }
        public Account SavingsAccount { get; set; }

        public void Transfer(decimal amount, AccountType fromAccount, AccountType toAccount)
        {
            if (fromAccount == AccountType.Checking && toAccount == AccountType.Savings)
            {
                CheckingAccount.Amount -= amount;
                SavingsAccount.Amount += amount;
            }
            else if (fromAccount == AccountType.Savings && toAccount == AccountType.Checking)
            {
                SavingsAccount.Amount -= amount;
                CheckingAccount.Amount += amount;                
            }
        }
    }
}
