using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Handling
{
    internal class FileInfo_Demo
    {
        static void Main()
        {
            string path = @"C:\Users\Admin\OneDrive\Desktop\.Net\File_Handling\File_Handling\demo.txt";

            if (File.Exists(path))
            {
                FileInfo f = new FileInfo(path);
                Console.WriteLine("Creation time: "+f.CreationTime);
                Console.WriteLine("Last access time: "+f.LastAccessTime);
                Console.WriteLine("Total length of file: "+f.Length);
                Console.WriteLine("Is Readonly? : "+f.IsReadOnly);
                Console.WriteLine("Full path of file: "+f.FullName);
                Console.WriteLine("Name of file: "+f.Name);
            }

        }
    }
}
