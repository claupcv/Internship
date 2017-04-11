using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingParameters
{
    public struct PersonRefParameter
    {
        public void Increment(ref int i)
        {
            i = i + 1;
            Console.WriteLine("Inside Increment :: i={0}",i);
        }
    }
}
