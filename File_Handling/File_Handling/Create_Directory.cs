using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Handling
{
    internal class Create_Directory
    {
        static void Main()
        {
            string folderPath = @"C:\\Users\\Admin\\OneDrive\\Desktop\\.Net\\File_Handling\\File_Handling\\DemoFolder";

            Directory.CreateDirectory(folderPath);
            Console.WriteLine("Directory created");

            //Directory.Delete(folderPath);
            //Console.WriteLine("Directoy Deleted");
        }
    }
}
