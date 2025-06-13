using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class _2dArray3
    {
        public static void App()
        {
            int[,] num = new int[3, 4];

            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j< 4; j++)
                {
                    Console.Write($"Enter number for position [{i},{j}]:");
                    num[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for(int i = 0; i < num.GetLength(0); i++)
            {
                for(int j = 0; j<num.GetLength(1); j++)
                {
                    Console.Write(num[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
