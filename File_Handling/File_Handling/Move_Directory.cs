using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Handling
{
    internal class Move_Directory
    {
        static void Main()
        {
            string source = @"C:\\Users\\Admin\\OneDrive\\Desktop\\.Net\\File_Handling\\DemoFolder";
            string destination = @"C:\\Users\\Admin\\OneDrive\\Desktop\\.Net\\File_Handling\\bin\\Debug\\net8.0\\DemoFolder1";

            if (Directory.Exists(source))
                Directory.Move(source, destination);

            Console.WriteLine("Directory Moved");
        }
    }
}
