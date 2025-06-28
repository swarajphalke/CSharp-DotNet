using System;
using System.IO;

namespace Exception_Handling
{
    internal class IO_Excep
    {
        static void Main(string[] args)
        {
            try
            {
                string sourcePath = @"C:\Users\Admin\OneDrive\Desktop\.Net\Files\source.txt";
                string destPath = @"C:\Users\Admin\OneDrive\Desktop\.Net\Files\destination.txt";

                if (File.Exists(sourcePath))
                {
                    File.Copy(sourcePath, destPath, true); // true allows overwriting
                    Console.WriteLine("File Copied Successfully");
                }
                else
                {
                    Console.WriteLine("Source file does not exist.");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Exception Caught: IO Problem Occurred");
                Console.WriteLine("Source Path: " + @"C:\Users\Admin\OneDrive\Desktop\.Net\Files\source.txt");
                Console.WriteLine("Destination Path: " + @"C:\Users\Admin\OneDrive\Desktop\.Net\Files\destination.txt");
                Console.WriteLine("Error Details: " + e.Message);
            }
        }
    }
}
