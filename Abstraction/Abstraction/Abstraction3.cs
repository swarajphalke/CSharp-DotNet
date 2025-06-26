using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Abstraction3
    {
        static void Main(String[] args)
        {
            Fulltimeemp fte = new Fulltimeemp();
            fte.getData();
            fte.putData();
            fte.calsal();

            Parttimeemp pte = new Parttimeemp();
            pte.getData();
            pte.putData();
            pte.calsal();
        }
    }

    internal abstract class Employee
    {
        int eid;
        string ename;
        protected double salary;
        string dept;
        public void getData()
        {
            Console.Write("Enter Id: ");
            eid = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Name: ");
            ename = Console.ReadLine();
            Console.Write("Enter Dept: ");
            dept = Console.ReadLine();
        }
        public void putData()
        {
            Console.WriteLine("Employee ID is {0}", eid);
            Console.WriteLine("Name is {0}", eid);
            Console.WriteLine("Dept is {0}", eid);
        }
        public abstract void calsal();
    }

    class Fulltimeemp : Employee
    {
        double annualsal;
        public override void calsal()
        {
            Console.Write("Enter Annual Salary: ");
            annualsal = Convert.ToDouble(Console.ReadLine());
            salary = annualsal / 12;
            Console.WriteLine("Salary of fullTime Employee is {0} ", salary);
        }
    }

    class Parttimeemp : Employee
    {
        int costperhr;
        int totalhr;
        public override void calsal()
        {
            Console.Write("Enter Cost per hour: ");
            costperhr = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Total hours: ");
            totalhr = Convert.ToInt32(Console.ReadLine());
            salary = costperhr * totalhr;
            Console.WriteLine("Salary of Part time employee is {0}", salary);
        }
    }

}
