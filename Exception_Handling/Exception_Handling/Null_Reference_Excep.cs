namespace Exception_Handling
{

    class Null_Reference_Excep
    {
        static void Main(string[] args)
        {
            try
            {
                string name = null;
                Console.WriteLine("Length of String: " + name.Length);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Exception Caught: you are trying to use null object");
                Console.WriteLine("Error Details: " + e.Message);
            }

            Console.ReadLine(); // Keeps the console window open
        }
    }
}