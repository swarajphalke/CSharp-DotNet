using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Interface2
    {
        public static void Main(String[] args)
        {
            Swaraj s = new Swaraj();
            s.Study();
            s.Play();
        }
    }

    interface IStudent
    {
        void Study();
    }
    interface ICricketer
    {
        void Play();
    }

    class Swaraj : IStudent, ICricketer
    {
        public void Study()
        {
            Console.WriteLine("Swaraj is Studying");
        }

        public void Play()
        {
            Console.WriteLine("Swaraj is Playing Cricket");
        }
    }
}
