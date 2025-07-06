using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection
{
    internal class MethodInjection
    {
        static void Main()
        {
            Account2 a = new Account2();
            a.printAccount(new SavingAccount2());

            Account2 a1 = new Account2();
            a1.printAccount(new CurrentAccount2());
        }
    }

    class Account2
    {
        public void printAccount(IAccount2 acc)
        {
            acc.printDetails();
        }
    }
    interface IAccount2
    {
        void printDetails();
    }

    class SavingAccount2 : IAccount2
    {
        public void printDetails()
        {
            Console.WriteLine("Printing details of saving account");
        }
    }
    class CurrentAccount2: IAccount2
    {
        public void printDetails()
        {
            Console.WriteLine("Printing details of current account"); // Corrected output string
        }
    }
}
