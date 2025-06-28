
namespace Encapsulation
{
    class Encapsulation1
    {
        static void Main(String[] args)
        {
            Student s = new Student();
            s.Name = ("Swaraj");
            Console.WriteLine(s.Name = ("Swaraj"));
        }
    }
    class Student
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }

}