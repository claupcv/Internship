using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class TestType
    {
        // by ":this" cals the second constructor(runs the body) and next will run the first constructor body
        public TestType(string context, int count) :this(context)
        {
            Console.WriteLine("TestType ctor in {0}={1}...", context,count);
        }
        
        public TestType(string context)
        {
            Console.WriteLine("TestType ctor in {0}...", context);
        }
    }
    public class BaseClass
    {
        private readonly TestType testBase = new TestType("BaseClass",2);
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
        private readonly TestType testDerived = new TestType("DerivedClass",1);
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
