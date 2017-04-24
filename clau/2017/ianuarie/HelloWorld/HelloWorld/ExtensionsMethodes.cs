using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    static class ExtensionsMethodes
    {
        public static int MultiplyBy(this int value, int multiplier)
        {
            return value * multiplier;
        }
    }
    public class ExtensionMethodesTest
    {
        public static void StaticMethodesTestMethod()
        {
            int result = 10.MultiplyBy(2).MultiplyBy(4);
            Console.WriteLine(result);
        }
    }
}
