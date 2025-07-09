using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class LINQ_Select_Projection1
    {
        static void Main()
        {
            
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var doubled = numbers.Select(n => n * 2);

            Console.WriteLine("Doubled Numbers: ");
            foreach (var num in doubled)
            {
                Console.WriteLine(num);
            }
        }
    }
}
