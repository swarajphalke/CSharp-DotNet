using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class _2dArray2
    {
        public static void App()
        {
            string[,] fruits = new string[3, 2]
            {
                { "mango", "pineapple "},
                {"jackfruit", "grape" },
                { "papaya", "custardapple"},
            };

            for(int i = 0; i < fruits.GetLength(0); i++)
            {
                for(int j = 0; j< fruits.GetLength(1); j++)
                {
                    Console.Write(fruits[i,j]+ "  ");
                }
                Console.WriteLine();
            }
        }
    }
}
