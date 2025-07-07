using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class LINQ_Join_GroupJoin1
    {

        static void Main() {
            List<Student> students = new List<Student>
        {
            new Student {Name = "Swaraj",DepartmentId=1},
            new Student {Name = "Om",DepartmentId=2},
            new Student {Name = "Purvesh",DepartmentId=1}
        };

            List<Department> departments = new List<Department>
        {
            new Department {Id = 1, DeptName="Computer" },
            new Department {Id = 2, DeptName = "Mechanical"}
        };

            var result = students.Join(
                departments,
                student => student.DepartmentId,
                dept => dept.Id,
                (student, dept) => new { student.Name, dept.DeptName}

                );

            Console.WriteLine("Inner Join Result: ");
            foreach(var item in result)
            {
                Console.WriteLine($"{item.Name} - {item.DeptName}");
            }
    }
    }
    class Student
    {
        public string Name;
        public int DepartmentId;
    }

    class Department
    {
        public int Id;
        public string DeptName;
    }
}
 