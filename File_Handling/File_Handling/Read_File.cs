using System;
using System.IO;

namespace File_Handling
{
    internal class Read_File
    {
        static void Main()
        {
            string path = @"C:\Users\Admin\OneDrive\Desktop\.Net\File_Handling\File_Handling\demo.txt";

            if (File.Exists(path))
            {
                string data = File.ReadAllText(path);
                Console.WriteLine("File Content: " + data);
            }
            else
            {
                Console.WriteLine("File not found at path: " + path);
            }
        }
    }
}
