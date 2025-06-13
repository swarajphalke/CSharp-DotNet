namespace Abstraction
{
    public class Abstraction1
    {
        static void Main(String[] args)
        {
            Vehicle c = new Car();
            c.start();
            c.sound();

            Vehicle b = new Bike();
            b.start();
            b.sound();

        }
    }

    abstract class Vehicle
    {
        public void start()
        {
            Console.WriteLine("Vehicle started...");
        }

        public abstract void sound();
    }

    class Car : Vehicle
    {
        public override void sound()
        {
            Console.WriteLine("Car making sound");
        }
    }

    class Bike : Vehicle
    {
        public override void sound()
        {
            Console.WriteLine("Bike Making sound");
         }

    }

}
