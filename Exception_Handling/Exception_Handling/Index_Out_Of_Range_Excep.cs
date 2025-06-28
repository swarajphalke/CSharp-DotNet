using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    internal class Index_Out_Of_Range_Excep
    {
        static void Main(string[] args)
        {
            try
            {
                int[] numbers = { 1, 2, 3 };
                Console.WriteLine("Element : " + numbers[5]);
            }catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("you tried to access an invalid index");
                Console.WriteLine("Error Details : "+e.Message);
            }
        }
    }

}
