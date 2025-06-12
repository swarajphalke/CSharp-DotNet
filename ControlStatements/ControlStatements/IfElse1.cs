using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlStructures
{
    internal class IfElse1
    {
        public static void Adult()
        {
            Console.Write("Enter your age : ");
            int age = Convert.ToInt32(Console.ReadLine()); 
            if(age>= 18)
            {
                Console.WriteLine("Your age is {0} so you are Adult", age);
            }
            else
            {
                Console.WriteLine("Your age is {0} so you are Not Adult", age);
            }
        
        }
    }
}
