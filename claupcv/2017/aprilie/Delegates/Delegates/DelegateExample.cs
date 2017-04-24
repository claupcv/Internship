using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate string SayHelloDelegate(string name);
    public delegate void AddNumDelegate(int a , int b);
    public class DelegateExample
    {
        public void AddNum(int a , int b)
        {
            Console.WriteLine(a+b);
        }
        public  static string SayHello(string name)
        {
            return "Hello " + name;
        }
    }
}
