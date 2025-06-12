using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Employee
    {
        int eid;
        string ename;
        double salary;
        string dept;

        public void getData()
        {
            Console.Write("Enter eid : ");
            eid = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter ename : ");
            ename = Console.ReadLine();
            Console.Write("Enter salary : ");
            salary = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter department : ");
            dept = Console.ReadLine();
        }

        public void putData()
        {
            Console.WriteLine();
            Console.WriteLine("Employee id is {0} : ", eid);
            Console.WriteLine("Employee name is {0} : ", ename);
            Console.WriteLine("Salary is {0} : ", salary);
            Console.WriteLine("Department is : {0} ", dept);
        }
    }
}
