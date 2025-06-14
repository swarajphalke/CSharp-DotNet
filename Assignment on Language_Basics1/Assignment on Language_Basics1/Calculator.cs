using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Language_Basics1
{
    internal class Calculator
    {
        
        public static void App()
        {
            Operations();
        }

        public static void Operations()
        {
            Console.Write("Enter A : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter B : ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Addition of A({0}) and B({1}) is : {2}", a, b, a + b);
            Console.WriteLine("Substraction of A({0}) and B({1}) is : {2}", a, b, a - b);
            Console.WriteLine("Multiplication of A({0}) and B({1}) is : {2}", a, b, a * b);
            Console.WriteLine("Division of A({0}) and B({1}) is : {2}", a, b, a / b);
            Console.ReadLine();

        }
    }
}
