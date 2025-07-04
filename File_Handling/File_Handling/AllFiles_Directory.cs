using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Handling
{
    internal class AllFiles_Directory
    {
        static void Main()
        {
            string folderPath = @"C:\Users\Admin\OneDrive\Desktop\.Net\File_Handling\File_Handling\\DemoFolder";

            if (Directory.Exists(folderPath))
            {
                string[] files = Directory.GetFiles(folderPath);
                Console.WriteLine("Files in folder:");
                foreach (string file in files)
                {
                    Console.WriteLine(file);
                }
            }
            else
            {
                Console.WriteLine("Folder does not exist.");
            }
        }
    }
}