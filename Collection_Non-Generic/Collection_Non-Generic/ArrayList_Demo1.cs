using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class ArrayList_Demo1
    {
     static void Main()
        {
            ArrayList arr = new ArrayList();

            arr.Add(100);
            arr.Add(200);

            Student s1 = new Student();
            s1.Rno = 1;
            s1.Name = "Swaraj";
            s1.Address = "Pune";
            s1.Marks = 67;
            arr.Add(s1);

            IEnumerator a = arr.GetEnumerator();
            while (a.MoveNext())
            {
                if(a.Current is Student)
                {
                    Student s5 = (Student)a.Current;
                    Console.WriteLine(s5.Rno+" "+s5.Name+" "+s5.Address+" "+s5.Marks);
                }
                else if(a.Current is int)
                {
                    Console.WriteLine(a.Current);
                }
            }
        }   
    }

    class Student
    {
        public int Rno { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Marks { get; set; }
    }
}
