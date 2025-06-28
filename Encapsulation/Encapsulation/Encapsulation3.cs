using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Encapsulation3
    {
        static void Main(String[] args)
        {
            BankAccount b = new BankAccount();
            b.AccountHolder = "Swaraj";
            b.Deposit( 1000);
            Console.WriteLine("Account Holder: $" + b.AccountHolder);
            Console.WriteLine("Current Balance: $"+ b.Balance);

        }
    }

    class BankAccount
    {
        private string accountHolder;
        private double balance;

        public String AccountHolder
        {
            get { return accountHolder; }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    accountHolder = value;
                }
            }
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                //Console.WriteLine($"Deposited ${amount}");
            }
            else
            {
                Console.WriteLine("Cannot deposit negative amount!");
            }
        }

        public double Balance
        {
            get { return balance; }
            
        }
    }

}
