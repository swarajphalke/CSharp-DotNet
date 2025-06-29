using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_and_Events
{
    internal class Delegate_Demo1
    {
        public delegate string Name(string name);
        public delegate void Salary(double salary);
        public delegate void Gender(string gender);

        public static string empName(string name)
        {
            return "Hello " + name;
        }

        public void empSalary(double salary)
        {
            Console.Write("Your Salary is: "+salary);
        }

        public void empGender(string gender)
        {
            Console.WriteLine(" and Your Gender is: "+gender);
        }

        static void Main(string[] args)
        {
            Name n = new Name(empName);

            Delegate_Demo1 d = new Delegate_Demo1();

            Salary s = new Salary(d.empSalary);
            Gender g = new Gender(d.empGender);

            String name = n.Invoke("Swaraj");
            Console.WriteLine(name);
            s.Invoke(56000);
            g.Invoke("Male");



        }
    }
}
