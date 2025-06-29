using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Init_Property
{
    internal class Indexer_Demo
    {
        static void Main()
        {
            Employee1 e = new Employee1();

            e[0] = 101;
            e[1] = "Abhishek";
            e[2] = 56000;
            e[3] = "Admin";

            Console.WriteLine(e[0]);
            Console.WriteLine(e[1]);
            Console.WriteLine(e[2]);
            Console.WriteLine(e[3]);
        }
    }

    class Employee1
    {
        int eid;
        string ename;
        double salary;
        string dept;

        public object this[int index]
        {
            get
            {
                if (index == 0)
                {
                    return eid;
                } else if(index == 1)
                {
                    return ename;
                }else if(index == 2)
                {
                    return salary;
                }
                else if(index==3)
                {
                    return dept;
                }
                else
                {
                    return null;
                }
            }

            set
            {
                if (index == 0)
                {
                   eid = Convert.ToInt32(value);
                }
                else if (index == 1)
                {
                    ename = value.ToString();
                }
                else if (index == 2)
                {
                     salary = Convert.ToDouble(value);
                }
                else if (index == 3)
                {
                    dept = value.ToString();
                }
               
            }
        }
    }
}
