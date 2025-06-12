using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOP
{
    public class Static_Constructor
    {
        // - Runs only once, automatically when the class is used the first time
        // - Used to initialize static data
        // - Cannot have parameters

        static string CompanyName;

        static Static_Constructor()
        {
            CompanyName = "Microsoft";
            Console.WriteLine("Static Constructor Called !");
        }

        public static void ShowComapnyName()
        {
            Console.WriteLine("Company : " + CompanyName);
        }
    }
}
