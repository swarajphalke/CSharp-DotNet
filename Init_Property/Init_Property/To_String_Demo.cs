using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Init_Property
{
    internal class To_String_Demo
    {
        static void Main()
        {
            Employee e = new Employee();
            e.Eid = 101;
            e.Ename = "Swaraj";
            Console.WriteLine(e.ToString());
        }
    }

    class Employee
    {
        int eid;
        string ename;

        public int Eid
        {
            get { return eid; }
            set { eid = value; }
        }

        public string Ename
        {
            get { return ename; }
            set { ename = value; }
        }

        public override string ToString()
        {
            return eid + ename;
        }
    }
}
