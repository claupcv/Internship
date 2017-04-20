using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingParameters
{
    public struct PersonOutParameter
    {
        public void IncrementOutExample(int count, out int incremented)
        {
            // intrucat utilizam "out"
            // este obligatoriu sa initializam "incremented" in cadrul metodei
            incremented = count;
            incremented++;

            Console.WriteLine("Inside Increment2 :: incremented={0}", incremented);
        }

    }
}
