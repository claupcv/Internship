using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public static class PassingParameters
    {
        public static void PassingParametersExample()
        {
            int arg, sumI;

            // Passing by value.
            // The value of arg in Main is not changed.
            arg = 4;
            squareVal(arg);
            Console.WriteLine(arg);
            // Output: 4

            // Passing by reference.
            // The value of arg in Main is changed.
            arg = 4;
            squareRef(ref arg);
            Console.WriteLine(arg);
            // Output: 16 

            //Passing by "out"
            arg = 4;
            sumI = 0;
            SumOutExample(arg, out sumI);
            Console.WriteLine(sumI);
        }

        static void squareVal(int valParameter)
        {
            valParameter *= valParameter;
        }

        // Passing by reference "ref"
        static void squareRef(ref int refParameter)
        {
            refParameter *= refParameter;
        }
        // Passing by "out"
        static void SumOutExample(int refParameter , out int sum)
        {
            sum = refParameter + 5;
        }

    }
}
