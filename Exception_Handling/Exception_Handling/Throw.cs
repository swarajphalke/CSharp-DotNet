using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    //The exception type is ArgumentException, meaning there's a problem with the input.
    internal class Throw
    {
        static void checkAge(int age)
        {
            if (age < 18)
            {
                throw new ArgumentException("You must be 18 or older");
            }
        }
        static void Main(String[] args)
        {
            try
            {
                checkAge(15);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Caught Exception : " + e.Message);
            }
        }
    }
}
