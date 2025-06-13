

namespace Inheritance
{
    internal class Inheritance2
    {
        static void Main(String[] args)
        {
            Car c = new Car("Toyota", 190);
            c.DisplayFuelType();    // Call Child class method
            c.DisplayInfo();    //Call base class method
        }
    }

    internal class Vehicle
    {
        string Brand;
        int Speed;

        public Vehicle(string Brand, int speed)
        {
            this.Brand = Brand;
            this.Speed = speed;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Vehicle Brand : " + Brand + " And Speed is : " + Speed);
        }
    }

    internal class Car : Vehicle
    {
        public string FuelType = "Disel";

        public Car(string Brand, int Speed) : base(Brand, Speed)
        {

        }
        public void DisplayFuelType()
        {
            Console.WriteLine(FuelType);
        }
    }
}
