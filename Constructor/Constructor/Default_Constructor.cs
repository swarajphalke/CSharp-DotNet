using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Default_Constructor
    {
        int eid;
        string ename;
        double salary;
        string dept;

        public Default_Constructor() //Default Constructor
        {
            eid = 0;
            ename = "Swaraj Phalke";
            salary = 65000;
            dept = "Software Testing";
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
