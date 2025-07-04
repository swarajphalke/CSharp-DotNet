using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Handling
{
    internal class DriveInfo_Demo
    {
        static void Main()
        {
            string s = @"c:\";

            DriveInfo d = new DriveInfo(s);

            Console.WriteLine("Drive Name: " + d.Name);
            Console.WriteLine("Drive Format: " + d.DriveFormat);
            Console.WriteLine("Drive Type: " + d.DriveType);
            Console.WriteLine("Total Size: " + d.TotalSize / (1024 * 1024 * 1024) + "GB");
            Console.WriteLine("Available Free Space: " + d.AvailableFreeSpace / (1024 * 1024 * 1024) + "GB");
            Console.WriteLine("Is Drive Ready to Use: " + d.IsReady);

            Console.WriteLine("\nDrives in " + d.Name + " Drive");
            foreach (DriveInfo di in DriveInfo.GetDrives())
            {
                Console.WriteLine("Drive Name: "+di.Name);
                Console.WriteLine("Drive Type: " + di.DriveType);
                Console.WriteLine("Drive Format: " + di.DriveFormat);
            }
        }
    }
}
