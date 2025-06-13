using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Array1
    {
        public static void App()
        {
            int[] num = { 10, 20, 30, 40, 50 };

            for(int i = 0; i<num.Length; i++)
            {
                Console.Write(num[i]+ " ");
            }
        }
    }
}
