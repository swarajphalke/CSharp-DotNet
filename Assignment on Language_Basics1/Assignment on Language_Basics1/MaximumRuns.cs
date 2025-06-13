using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Language_Basics1
{
    internal class MaximumRuns
    {
        public static void App()
        {
            Players();
        }

        public static void Players()
        {
            int[] runs = new int[5];

            Console.WriteLine("Enter runs scored by 5 players : ");
            for (int i = 0; i < runs.Length; i++)
            {
                Console.Write("Player " + (i + 1) + ": ");
                runs[i] = Convert.ToInt32(Console.ReadLine());
            }

            int max = runs[0];
            for (int i = 0; i < runs.Length; i++)
            {
                if (runs[i] > max)
                {
                    max = runs[i];
                }
            }

            Console.Write("Maximum runs scored : {0}", max);
        }
    }
}
