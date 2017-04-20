using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadedOperators
{
    class Program
    {
        static void Main(string[] args)
        {


            var p1 = new Point2D(100, 100);
            var p2 = new Point2D(150, 130);
            var displacement = new Displacement2D(50, 30);

            var p3 = p1 + displacement;
            var p4 = p2 - displacement;

            // Prints "True"
            Console.WriteLine(p1 != p2);

            // Prints "False"
            Console.WriteLine(p1 == p2);

            // Prints "True"
            Console.WriteLine(p2 == p3);

            // Prints "True"
            Console.WriteLine(p1 == p4);

            Console.ReadKey();

        }
    }
}
