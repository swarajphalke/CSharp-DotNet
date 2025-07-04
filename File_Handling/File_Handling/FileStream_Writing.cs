using System;
using System.IO;
using System.Text;

namespace File_Handling
{
    internal class FileStream_Writing
    {
        static void Main(string[] args)
        {
            string file = @"C:\Users\Admin\OneDrive\Desktop\myFolder_Updated\Demo.txt";
            string content = "Hello Swaraj! FileStream Writing...";

            // Convert string to bytes
            byte[] data = Encoding.UTF8.GetBytes(content);


            // Create and write

            using (FileStream fs = new FileStream(file, FileMode.Create, FileAccess.Write))
            {
                fs.Write(data, 0, data.Length);  // writing byte array to file
                Console.WriteLine("Data written to file using FileStream.");
            }
            ;




        }
    }
}
