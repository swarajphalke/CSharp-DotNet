using System;
using System.IO;
using System.IO.Compression;
namespace File_Handling
{
    internal class GZipStream_File_Compression
    {
        static void Main(string[] args)
        {
            string sourceFile = @"C:\Users\Admin\OneDrive\Desktop\myFolder_Updated\Demo.txt";
            string compressedFile = @"C:\Users\Admin\OneDrive\Desktop\myFolder_Updated\Compressed.gz";

            // Create original file if not exists
            if (!File.Exists(sourceFile))
            {
                File.WriteAllText(sourceFile, "This is a large file. Compress it to save space!");
            }

            using (FileStream sourceStream = new FileStream(sourceFile, FileMode.OpenOrCreate, FileAccess.Read))
            using (FileStream destStream = new FileStream(compressedFile, FileMode.Create))
            using (GZipStream compressionStream = new GZipStream(destStream, CompressionMode.Compress))
            {
                sourceStream.CopyTo(compressionStream);
                Console.WriteLine("File compressed to: " + compressedFile);
            }
        }
    }
}
