using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlStructures
{
    internal class Switch
    {
        public static void Calculator()
        {
            while (true)
            {
                Console.Write("Enter First Number : ");
                int first = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Second NUmber : ");
                int second = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Operation (+, -, *, /) : ");
                string operation = Console.ReadLine();

                Console.WriteLine();

                switch (operation)
                {
                    case "+":
                        Console.WriteLine($"Result: {first + second}");
                        break;

                    case "-":
                        Console.WriteLine($"Result: {first - second}");
                        break;

                    case "*":
                        Console.WriteLine($"Result: {first * second}");
                        break;

                    case "/":
                        if (second != 0)
                            Console.WriteLine("Result: {first/second}");
                        else
                            Console.WriteLine("Error: Division by zero");
                        break;

                    default:
                        Console.WriteLine("Invalid Operation.");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}