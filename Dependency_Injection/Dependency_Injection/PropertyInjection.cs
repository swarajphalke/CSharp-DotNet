using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection
{
    internal class PropertyInjection
    {
        static void Main()
        {
            // Create an object of Account class
            Account1 a = new Account1();

            // Inject SavingAccount object using the property
            a.acc = new SavingAccount1();
            a.printAccount();   // Output: Printing details of saving account


            // Inject CurrentAccount object using the same property
            a.acc = new CurrentAccount1();
            a.printAccount();  // Output: Printing details of current account

        }
    }

    interface IAccount1
    {
        void printDetails();
    }

    class SavingAccount1:IAccount1
    {
        public void printDetails()
        {
            Console.WriteLine("Printing details of saving account");
        }
    }

    class CurrentAccount1 : IAccount1
    {
        public void printDetails()
        {
           Console.WriteLine("Printing details of saving account");
        }
    }

    class Account1
    {
        public IAccount1 acc { get; set; }

        public void printAccount()
        {
            acc.printDetails();
        }
    }
}
