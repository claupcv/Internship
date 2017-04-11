using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p = new Person("John", "Doe");
            Student s = new Student("Sally", "Moe", "University of Oradea");

            p.PresentYourself();
            s.PresentYourself();

            PersonExtension.PresentYourself(p);

            Console.ReadKey();

        }
    }
}
