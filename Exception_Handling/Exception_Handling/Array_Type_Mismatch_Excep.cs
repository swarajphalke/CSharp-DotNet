using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exception_Handling
{
    internal class Array_Type_Mismatch_Excep
    {
        static void Main(string[] args)
        {
            string[] s = new string[5] { "aaa", "bbb", "ccc", "ddd", "eee"};
            int[] a = new int[5];

            try
            {
                Array.Copy(s, a, 5);
                //Copy 5 elements from the array s into the array a, starting at index 0 in both arrays.


            }
            catch (ArrayTypeMismatchException e)
            {
                Console.WriteLine("Source and Destination type must be same..!");
            }
            finally
            {
                Console.WriteLine("In Finally Block");
            }

        }
    }
}
