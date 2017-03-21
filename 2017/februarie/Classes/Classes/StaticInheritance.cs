using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class StaticInheritanceBaseClass
    {
        public static void Test()
        {
            Console.WriteLine("Test");
        }
    }

    public class StaticInheritanceDerivedClass : StaticInheritanceBaseClass
    {

    }
}
