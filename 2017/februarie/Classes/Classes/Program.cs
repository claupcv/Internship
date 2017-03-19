using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            //Membrii de instanta si membrii statici
            // instance
            Person person1 = new Person();
            Person person2 = new Person();

            person1.PrintPopCount();
            person2.PrintPopCount();

            person1.DoSomethingWithPopulationCount();

            person1.PrintPopCount();
            person2.PrintPopCount();



            Person.PopCount++;
            Console.WriteLine("Now the global population count raised to {0}", Person.PopCount);
            Console.ReadKey();
        }
    }
}
