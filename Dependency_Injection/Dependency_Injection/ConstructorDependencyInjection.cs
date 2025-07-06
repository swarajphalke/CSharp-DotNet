using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection
{
    internal class ConstructorDependencyInjection
    {
        static void Main()
        {
            IAccount s = new SavingAccount();   // Create an object of SavingAccount and assign to interface reference
            Account ass = new Account(s);    // Inject it into the Account class constructor
            ass.printAccount();  // Calls printdetails() of SavingAccount

            IAccount c = new CurrentAccount();
            Account acc = new Account(c);
            acc.printAccount();
        }
    }


    class Account
    {
        IAccount iacc;

        public Account(IAccount iacc)
        {
            this.iacc = iacc;
        }

        public void printAccount()
        {
            iacc.printDetails();
        }
    }

    interface IAccount
    {
        void printDetails();
    }

    class SavingAccount : IAccount
    {
        public void printDetails()
        {
            Console.WriteLine("printing details of saving account");
        }
    }

    class CurrentAccount : IAccount
    {
        public void printDetails()
        {
            Console.WriteLine("printing details of current account");
        }
    }
}