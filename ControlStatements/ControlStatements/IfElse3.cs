using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlStructures
{
    internal class IfElse3
    {
        public static void LoginCheck()
        {
            Console.Write("Enter you username : ");
            string username = Convert.ToString(Console.ReadLine());

            if(username == "admin")
            {
                Console.WriteLine("Login Successful");
            }
            else
            {
                Console.WriteLine("Invalid Username");
            }
        }
    }
}
