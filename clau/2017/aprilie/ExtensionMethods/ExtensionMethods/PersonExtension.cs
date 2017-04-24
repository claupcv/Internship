using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    static class  PersonExtension
    {

        // extension method
        public static void PresentYourself(this Person p)
        {
            if (p != null)
            {
                Console.WriteLine("Hello, my name is {0} {1}", p.FirstName, p.LastName);
            }
        }

        public static void  TestExtensions()
        {

        }
    }
}
