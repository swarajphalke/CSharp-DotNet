using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    internal class Argument_Excep
    {
        static void PrintName(String name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name cannot be empty or whitespace.");
            }
            Console.WriteLine("Hello "+ name);

        }
        static void Main(String[] args)
        {
            try
            {
                PrintName(""); // Invalid input
            }catch(ArgumentException e)
            {
                Console.WriteLine("Caught ArgumentException: " + e.Message);
            }
        }
    }
}
