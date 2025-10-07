using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class LINQ_Aggregate_Functions1
    {
        static void Main()
        {
            int[] marks = { 85, 90, 78, 92, 60 };

            int total = marks.Sum();
            double average = marks.Average();
            int count = marks.Count();
            int min = marks.Min();
            int max = marks.Max();

            Console.WriteLine("Total: " + total);
            Console.WriteLine("Average: " + average);
            Console.WriteLine("Count: " + count);
            Console.WriteLine("Minimun: " + min);
            Console.WriteLine("Maximum: " + max);

        }
    }
}
