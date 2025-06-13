using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Language_Basics1
{
    internal class Matrix3x2
    {
        public static void App()
        {
            int[,] matrix = new int[3, 2]
            {
                { 1,2},
                { 3,4},
                { 5,6},
            };

            Console.WriteLine("3x2 Matrix : ");
            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
