using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Parameterized_Constructor1
    {
        int eid;
        string ename;
        double salary;
        string dept;

        public Parameterized_Constructor1(int eid, string ename, double salary, string dept)
        {
            this.eid = eid;
            this.ename = ename;
            this.salary = salary;
            this.dept = dept;
        }

        public void putData()
        {
            Console.WriteLine("Employee id is {0}", eid);
            Console.WriteLine("Employee name is {0}", ename);
            Console.WriteLine("Employee salary is {0}", salary);
            Console.WriteLine("Employee department is {0}", dept);
        }
    }
}
