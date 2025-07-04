using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Handling
{
    internal class Path_Demo
    {
        static void Main()
        {
            string path = @"C:File_Handling\demo.txt";

            Console.WriteLine("Full Path of File: "+Path.GetFullPath(path));
            Console.WriteLine("Directory inside Path: "+Path.GetDirectoryName(path));
            Console.WriteLine("Filename from file: "+Path.GetFileName(path));
            Console.WriteLine("Change extension of file: "+Path.ChangeExtension(path,".html"));

        }
    }
}
