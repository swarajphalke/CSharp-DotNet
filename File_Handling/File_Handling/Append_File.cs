using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Handling
{
    internal class Append_File
    {
        static void Main()
        {
            string path = @"C:\Users\Admin\OneDrive\Desktop\.Net\File_Handling\File_Handling\demo.txt";
            string content = "\nThis is new line";

            if (File.Exists(path))
            {
                File.AppendAllText(path, content);
                Console.WriteLine("Content Added");
            }
            else
            {
                Console.WriteLine("File not found");
            }
        }
    }
}
