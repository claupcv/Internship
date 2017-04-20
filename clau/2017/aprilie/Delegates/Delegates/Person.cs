using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class Person
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public delegate int Sum3Numbers(int a1, int a2, int a3);

        int CalculateSum3Numbers(int a1, int a2, int a3)
        {
            return a1 + a2 + a3;
        }

        int CalculateDif3Numbers(int a1, int a2, int a3)
        {
            return a1 - a2 - a3;
        }

        public void Run()
        {
            Sum3Numbers delegateSum = null;
            delegateSum += CalculateSum3Numbers;

            delegateSum += CalculateDif3Numbers;

            var result = delegateSum(9, 8, 7);

            // Will print: 6
            Console.WriteLine(result);
        }

    }
}
