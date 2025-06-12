using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Method_Para_params
    {
        public static void Params()
        {
            ShowNumber(1, 2, 3, 4, 5);
        }

        static void ShowNumber(params int[] numbers)
        {
            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}
