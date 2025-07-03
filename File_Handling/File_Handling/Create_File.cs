using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Handling
{
    internal class Create_File
    {
        static void Main()
        {
            string path = @"C:\\Users\\Admin\\OneDrive\\Desktop\\.Net\\File_Handling\\File_Handling\\demo.txt";
            string content = "Hello from c#";

            File.WriteAllText(path, content);

            Console.WriteLine("File created and written");

            //File.Delete("demo.txt");
            //Console.WriteLine("File deleted successfully");

        }
    }
}
