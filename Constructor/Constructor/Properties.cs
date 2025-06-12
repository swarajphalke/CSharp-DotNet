using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{

    internal class Properties
    {
        int eid;
        string ename;
        double salary;
        string dept;

        public Properties(int eid, string ename, double salary, string dept)
        {
            this.eid = eid;
            this.ename = ename;
            this.salary = salary;
            this.dept = dept;
        }

        public int Eid
        {
            get   //Read Only Property
            {
                return eid;
            }
            set   //Write Only Property
            {
                if (value <= 0)
                    Console.WriteLine("1) Employee Id should not be less than 0");
                else
                    eid = value;
            }
        }

        public string Ename
        {
            get
            {
                return ename;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    Console.WriteLine("2) Employee Name should not be Null or Empty");
                else
                    ename = value;
            }
        }

        public double Salary
        {
            get
            {
                return salary;
            }
            set
            {
                if (value >= 50000 && value <= 100000)
                    salary = value;
                else
                    Console.WriteLine("3) Please enter Salary in between 50 to 1 Lakh");
            }
        }

        public string Dept
        {
            get
            {
                return dept;
            }
            set
            {
                dept = value;
            }
        }

        public void putData()
        {
            Console.WriteLine();
            Console.WriteLine("Employee Id is : {0}", eid);
            Console.WriteLine("Employee Name is : {0}", ename);
            Console.WriteLine("Employee Salary is : {0}", salary);
            Console.WriteLine("Employee Department is : {0}", dept);
        }
    }
}
