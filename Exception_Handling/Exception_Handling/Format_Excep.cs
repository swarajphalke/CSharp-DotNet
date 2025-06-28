using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    internal class Format_Excep
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter your age: ");
                string input = Console.ReadLine();

                int age = int.Parse(input); //error
                Console.WriteLine("Your age is : " + age);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Invalid format, Please enter a num");
                Console.WriteLine("Error Details: " + e.Message);
            }
        }
    }

}
