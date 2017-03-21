using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class TestType
    {
        public TestType(string context)
        {
            Console.WriteLine("TestType ctor in {0}...", context);
        }
    }
    public class BaseClass
    {
        private readonly TestType testBase = new TestType("BaseClass");
        public BaseClass()
        {
            Console.WriteLine("BaseClass ctor  ...");
        }

        ~BaseClass()
        {
            Console.WriteLine("BaseClass destructor ...");
        }
    }
 
    public class DerivedClass : BaseClass
    {
        private readonly TestType testDerived = new TestType("DerivedClass");
        public DerivedClass()
        {
            Console.WriteLine("DerivedClass ctor ...");
        }

        ~DerivedClass()
        {
            Console.WriteLine("DerivedClass destructor ...");
        }
    }
}
