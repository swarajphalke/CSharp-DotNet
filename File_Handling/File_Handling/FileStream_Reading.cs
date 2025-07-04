using System;
using System.IO;
using System.Text;

namespace File_Handling
{
    internal class Filestreme_Reading
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Admin\OneDrive\Desktop\myFolder_Updated\Demo.txt";

            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[fs.Length]; // Size = file size in bytes
                fs.Read(buffer, 0, buffer.Length);

                // Convert bytes to string
                string result = Encoding.UTF8.GetString(buffer);
                Console.WriteLine("File content: " + result);
            }

        }
    }
}
