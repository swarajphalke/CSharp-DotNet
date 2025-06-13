namespace Interface
{
    class Interface1
    {
        static void Main(String[] args)
        {
            IVehicle v1 = new Car();
            v1.Start();
            v1.Stop();

            Console.WriteLine();

            IVehicle v2 = new Bike();
            v2.Start();
            v2.Stop();
        }
    }

    interface IVehicle
    {
        void Start();
        void Stop();
    }

    class Car : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Car Started");
        }
        public void Stop()
        {
            Console.WriteLine("Car Stopped");
        }
    }

    class Bike: IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Bike Started");
        }

        public void Stop()
        {
            Console.WriteLine("Bike Stopped");
        }
    }
}