using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Handling
{
    internal class Check_Directory
    {
        static void Main()
        {
            string folderPath = @"C:\Users\Admin\OneDrive\Desktop\.Net\File_Handling\File_Handling\\DemoFolder";

            if (Directory.Exists(folderPath))
            {
                Console.WriteLine("Directory exists");
            }
            else
            {
                Console.WriteLine("Directory does not exist");
            }

        }
    }
}
