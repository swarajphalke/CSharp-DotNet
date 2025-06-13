using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Abstraction2
    {
        static void Main(String[] args)
        {
            Payment p1 = new CreditCardPayment();
            p1.ConnectToBank();
            p1.ValidateDetails();
            p1.MakePayment();

            Console.WriteLine();

            Payment p2 = new UPIPayment();
            p2.ConnectToBank();
            p2.ValidateDetails();
            p2.MakePayment();
        }
    }

    abstract class Payment
    {
        public void ConnectToBank()
        {
            Console.WriteLine("Connecting to bank...");
        }

        public abstract void ValidateDetails();
        public abstract void MakePayment();
    }

    class CreditCardPayment:Payment
    {
        public override void ValidateDetails()
        {
            Console.WriteLine("Validating Credit Card number and CVV...");
        }
        public override void MakePayment()
        {
            Console.WriteLine("Processing Credit Card Payment...");
        }
    }

    class UPIPayment:Payment
    {
        public override void ValidateDetails()
        {
            Console.WriteLine("Validating UPI and PIN...");
        }

        public override void MakePayment()
        {
            Console.WriteLine("Processing UPI Payment");
        }

    }
}
