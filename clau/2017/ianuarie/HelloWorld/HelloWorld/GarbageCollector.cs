using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class GarbageCollector : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine(0);
        }

    }

    public class TestGarbageCollector
    {
        public static void TestMethod()
        {
            using (GarbageCollector objGC = new GarbageCollector())
            {
                Console.WriteLine(1);
            }
            Console.WriteLine(2);
        }
        
    }
}
