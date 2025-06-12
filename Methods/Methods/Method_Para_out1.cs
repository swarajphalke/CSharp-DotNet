using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Method_Para_out1
    {
        public static void Out()
        {
            int m, s;
            getMarks(out m, out s);

            Console.WriteLine("Math Marks : " + m);
            Console.WriteLine("Science Marks : {0} ", s);
        }
        static void getMarks(out int mathMarks, out int scienceMarks)
        {
            mathMarks = 85;
            scienceMarks = 90;
        }

    }
}
