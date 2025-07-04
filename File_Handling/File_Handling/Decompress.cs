using System;
using System.IO;
using System.IO.Compression;

namespace File_Handling
{
    internal class Decompress
    {
        static void Main()
        {
            string compressedFile = @"C:\Users\Admin\OneDrive\Desktop\myFolder_Updated\Compressed.gz";
            string decompressedFile = @"C:\Users\Admin\OneDrive\Desktop\myFolder_Updated\decompressed.txt";

            using (FileStream sourceStream = new FileStream(compressedFile, FileMode.Open))
            using (FileStream destStream = new FileStream(decompressedFile, FileMode.Create))
            using (GZipStream decompressionStream = new GZipStream(sourceStream, CompressionMode.Decompress))
            {
                decompressionStream.CopyTo(destStream);
                Console.WriteLine("File decompressed to: " + decompressedFile);
            }
        }
    }
}