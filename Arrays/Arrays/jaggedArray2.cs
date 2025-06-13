using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class jaggedArray2
    {
        public static void App()
        {
            string[][] names = new string[][]
            {
                new string[] {"Swaraj", "Viraj"},
                new string[] {"Siddharth"},
                new string[] {"Aditya", "Mayuresh","Vinayak"},
                
            };

            foreach(string[] group in names)
            {
                foreach(string name in group)
                {
                    Console.Write(name+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
