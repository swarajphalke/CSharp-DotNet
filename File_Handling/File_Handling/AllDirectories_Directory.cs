using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Handling
{
    internal class AllDirectories_Directory
    {
        static void Main()
        {
            string folderPath = @"C:\Users\Admin\OneDrive\Desktop\.Net\File_Handling\File_Handling\\DemoFolder";

            if (Directory.Exists(folderPath))
            {
                string[] folders = Directory.GetDirectories(folderPath);
                Console.WriteLine("Directories is Directory:");
                foreach(string folder in folders)
                {
                    Console.WriteLine(folder);
                }
            }
            else
            {
                Console.WriteLine("Directory not found");
            }
        }
    }
}
