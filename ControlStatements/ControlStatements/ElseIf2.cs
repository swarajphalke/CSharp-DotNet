using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlStructures
{
    internal class ElseIf2
    {
        public static void TemperatureStatus()
        {
            Console.Write("Enter Temperature in you city : ");
            int temp = Convert.ToInt32(Console.ReadLine());

            if(temp >= 40)
            {
                Console.WriteLine("Very Hot");
            }else if(temp >= 30){
                Console.WriteLine("Hot");
            }else
            {
                Console.WriteLine("Normal");
            }
        }
    }
}
