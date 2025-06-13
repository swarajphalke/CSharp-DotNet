using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class jaggedArray1
    {
        public static void App()
        {
            int[][] jagged = new int[][]
            {
                new int[] {1,2,3},
                new int[] {4,5},
                new int[] {6},
            };

            for(int i = 0; i < jagged.Length; i++)
            {
                for(int j = 0; j< jagged[i].Length; j++)
                {
                    Console.Write(jagged[i][j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}

