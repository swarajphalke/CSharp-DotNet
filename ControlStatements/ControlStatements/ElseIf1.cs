using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlStructures
{
        internal class ElseIf1
    {
        public static void GradeSystem()
        {
            Console.Write("Enter your marks : ");
            int score = Convert.ToInt32(Console.ReadLine());

            if (score >= 90)
            {
                Console.WriteLine("A Grade");
            }
            else if (score >= 75)
            {
                Console.WriteLine("B Grade");
            }
            else if (score >= 60)
            {
                Console.WriteLine("C Grade");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
    }
}
