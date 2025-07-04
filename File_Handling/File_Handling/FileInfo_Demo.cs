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
            string path = @"C:\Users\Admin\OneDrive\Desktop\.Net\File_Handling\File_Handling\myfile.txt";
            FileInfo file = new FileInfo(path);

            // ---------- Create and Write ----------
            if (!file.Exists)
            {
                using (StreamWriter writer = file.CreateText())
                {
                    writer.WriteLine("Hello Swaraj! How are you ?");
                }
                Console.WriteLine("File Created Successfully");
            }

            // ---------- Properties ----------
            Console.WriteLine($"Name: {file.Name}");
            Console.WriteLine($"Full Path: {file.FullName}");
            Console.WriteLine($"Extension: {file.Extension}");
            Console.WriteLine($"Exists? {file.Exists}");
            Console.WriteLine($"Directory: {file.DirectoryName}");
            Console.WriteLine($"Created: {file.CreationTime}");
            Console.WriteLine($"Last Modify: {file.LastWriteTime}");
            Console.WriteLine($"Last Access: {file.LastAccessTime}");
            Console.WriteLine($"File Length: {file.Length} bytes");
            Console.WriteLine($"File Readable? {file.IsReadOnly}");
            Console.WriteLine($"Attributes: {file.Attributes}");

            //  ---------- Methods ----------

            //3.1 Copy
            string copiedPath = @"C:\Users\Admin\OneDrive\Desktop\.Net\File_Handling\File_Handling\copy_myfile.txt";
            if (!File.Exists(copiedPath))
            {
                file.CopyTo(copiedPath);
                Console.WriteLine("\nFile copied to: " + copiedPath);
            }

            // 3.2 Move (Rename)
            string movePath = @"C:\Users\Admin\OneDrive\Desktop\.Net\File_Handling\File_Handling\sample_one.txt"; 
            if (!File.Exists(movePath))
            {
                file.MoveTo(movePath);
                Console.WriteLine("\nFile moved/renamed to: " + movePath);

                // IMPORTANT: update FileInfo object to new path
                file = new FileInfo(movePath);
            }

            // 3.3 Open for reading
            Console.WriteLine("\nReading file content:");
            using (StreamReader reader = file.OpenText())
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(">> " + line);
                }
            }

            // 3.4 Open for writing (overwrites)
            Console.WriteLine("\n✍️ Overwriting content...");
            using (StreamWriter writer = new StreamWriter(file.FullName))
            {
                writer.WriteLine("This content is overwritten.");
                writer.WriteLine("Good job, Swaraj!");
            }

            // 3.5 OpenWrite and OpenRead (FileStream)
            Console.WriteLine("\nOpening with OpenWrite and OpenRead:");
            using (FileStream writeStream = file.OpenWrite())
            {
                byte[] data = System.Text.Encoding.UTF8.GetBytes("Adding from OpenWrite.\n");
                writeStream.Write(data, 0, data.Length);
            }

            using (FileStream readStream = file.OpenRead())
            {
                byte[] buffer = new byte[readStream.Length];
                readStream.Read(buffer, 0, buffer.Length);
                string text = System.Text.Encoding.UTF8.GetString(buffer);
                Console.WriteLine("From OpenRead:\n" + text);
            }

            // 3.6 Set ReadOnly attribute
            file.IsReadOnly = true;
            Console.WriteLine("File marked as read-only.");

            // 3.7 Remove ReadOnly
            file.IsReadOnly = false;
            Console.WriteLine("File unmarked as read-only.");

            // 3.8 Delete (Uncomment to test)
            // file.Delete();
            // Console.WriteLine("❌ File deleted.");
        }
    }
}
