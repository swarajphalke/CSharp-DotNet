
using OOP;
namespace OOP
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Employee ->
            Employee e1 = new Employee();
            e1.getData();
            e1.putData();


            //Default Constructor ->
            //Default_Constructor c1 = new Default_Constructor();
            //c1.putData();


            //Parameterized Constructor1 ->
            //Parameterized_Constructor1 p1 = new Parameterized_Constructor1(02, "Swaraj Phalke", 67000, "Software Developer");
            //p1.putData();


            //Parameterized Constructor2 ->
            //Parameterized_Constructor2 p2 = new Parameterized_Constructor2("Wings of Fire","Apj Abdul Kalam");
            //p2.putData();


            //Copy Constructor ->
            //Copy_Constructor c1 = new Copy_Constructor("Mayuresh", 22);
            //Copy_Constructor c2 = new Copy_Constructor(c1);
            //Console.WriteLine("Original Student");
            //c1.putData();
            //Console.WriteLine();
            //Console.WriteLine("Copied Student");
            //c2.putData();


            //Private Constructor ->
            //int result = Private_Constructor.Square(4);
            //Console.WriteLine(result);


            //Static Constructor ->
            //Static_Constructor.ShowComapnyName(); // Static constructor called here automatically
            //Console.WriteLine();
            //Static_Constructor.ShowComapnyName(); // This time, static constructor will not run again


            //Properties ->
            //Properties p = new Properties(2, "Aditya", 56000, "Manager");
            //p.Eid = 3;
            //p.Ename = null;
            //p.Salary = 4000;
            //p.Dept = "Software Engineer";
            //p.putData();


            Console.ReadLine();
        }
    }
}
