using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    internal class Custom_Excep : Exception
    {
        public Custom_Excep(string message) : base(message)
        {

        }
    }

    class Bank
    {
        public void withdraw(int balance)
        {
            if (balance < 500)
            {
                throw new Custom_Excep("Balance is below minimun threshold");
            }
            else
            {
                Console.WriteLine("Withdraw Successflly");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Bank b = new Bank();
            try
            {
                b.withdraw(300);
            }
            catch (Custom_Excep e)
            {
                Console.WriteLine("Custom Exception: " + e.Message);
            }
        }
    }
}
