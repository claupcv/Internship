using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Person
    {
        public string PersonName = string.Empty;

        public static int PopCount = 0;

        public void PrintPopCount()
        {
            // accesam membru static pt. citire
            Console.WriteLine("Population count is: " + Person.PopCount);
        }

        public void DoSomethingWithPopulationCount()
        {
            // accesam membru static pt. scriere
            Person.PopCount = 100;
        }


    }
}
