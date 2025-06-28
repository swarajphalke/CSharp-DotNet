using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    internal class File_Not_Found_Excep
    {
        static void Main(string[] args)
        {
            try
            {
                string content = File.ReadAllText("nonexistent.txt");
                Console.WriteLine("File Content: \n "+content);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Exception Caught: File not found");
                Console.WriteLine("Error Details: "+ e.Message);
            }
        }
    }
}
