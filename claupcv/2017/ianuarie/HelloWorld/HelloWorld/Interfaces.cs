using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    using System.Security.Cryptography.X509Certificates;

    public interface ICustomer<T, Y>
    {
        T Sum(int x, int y);
        Y Sum2(Y x, Y y);
    }
    class Interfaces : ICustomer<int, string>
    {
        public int Sum(int x, int y)
        {
            //Console.WriteLine(x * y);
            return x * y;
        }
        public string Sum2(string x, string y)
        {
            //Console.WriteLine(x +"-"+ y);
            return x + "-" + y;
        }

        public static void RunInterface()
        {
            Interfaces interInstance = new Interfaces();
            Console.WriteLine(interInstance.Sum(4,6));
            Console.WriteLine(interInstance.Sum2("4", "6"));
        }
    }
}
