using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public static class OverloadingMethods
    {
        
        static void MethodOver(int i)
        {            
            Console.WriteLine("Method int;");
        }

        static void MethodOver(double i)
        {
            Console.WriteLine("Method double;");
        }
        public static void OverloadingMethodExample()
        {
            // based on the parameter type will choose the corect method.
            MethodOver(1.6);
        }
    }
}
