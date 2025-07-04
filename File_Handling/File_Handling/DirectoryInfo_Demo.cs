using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Handling
{
    internal class DirectoryInfo_Demo
    {
        static void Main()
        {
            string folderPath = @"C:\Users\Admin\OneDrive\Desktop\.Net\File_Handling\File_Handling\\DemoFolder";

            DirectoryInfo d = new DirectoryInfo(folderPath);

            if (d.Exists)
            {
                Console.WriteLine("Directory Fullname: "+d.FullName);
                Console.WriteLine("Directory Name: "+d.Name);
                Console.WriteLine("Last Access Time: "+d.LastAccessTime);
                Console.WriteLine("Creation Time: "+d.CreationTime);
            }
            else
            {
                Console.WriteLine("Directory does not exist");
            }

            Console.WriteLine("\nFiles in Directory");
            foreach(FileInfo f in d.GetFiles())
            {
                Console.WriteLine(f);
            }

            Console.WriteLine("\nDirectories in Directory");
            foreach(DirectoryInfo di in d.GetDirectories())
            {
                Console.WriteLine(di);
            }
         }
    }
}
