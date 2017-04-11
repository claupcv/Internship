using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {

            RectangleStruct r = new RectangleStruct();

            //RectangleStruct r;
            r.X = 100;
            r.Y = 100;
            r.Width = 50;
            r.Height = 50;

            RectangleStruct r1 = r;

            r1.X = 200;

            // the struct is a  value type so it copies the value also in stack.
            // r and r1 are two diferent structs in stack, so will be (r.X != r1.X)
            Console.WriteLine("p : {0}", r.X);

            Console.WriteLine("p : {0}", r1.X);

            Console.ReadKey();

        }
    }
}
