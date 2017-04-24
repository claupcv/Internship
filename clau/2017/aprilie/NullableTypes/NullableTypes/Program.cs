using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int intNorm = 5;
            Nullable<int>nullableInt1 = 10 ;

            // from int? to int only with implicit cast
            intNorm = (int)nullableInt1;
            // Will print: Nullable int 1 :: direct usage :: 10
            Console.WriteLine("Nullable int 1 :: direct usage :: {0}", nullableInt1.HasValue);

            if (nullableInt1.HasValue)
            {
                Console.WriteLine("Are ba valoare:{0}", nullableInt1.HasValue);
            }
            

            Person person = null;
            // this works as expected
            Console.WriteLine("Person name: " + person?.FirstName);
 
            int? i = null;
            // Doesn't work because of operator lifting
            // compiler error says:
            // 'int' does not contain a definition for 'Value' and no extension method 'Value' accepting a first argument of type 'int' could be found
            Console.WriteLine("I value: " + i?.Value);

            Console.ReadKey();

        }
    }
}
