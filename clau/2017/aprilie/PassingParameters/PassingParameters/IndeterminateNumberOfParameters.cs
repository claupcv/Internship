using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingParameters
{
    public class IndeterminateNumberOfParameters
    {
        private int Sum(params int[] args)
        {
            int sum = 0;
            if (args != null)
            {
                for (int i = 0; i < args.Length; i++)
                {
                    sum = sum + args[i];
                }
            }
            return sum;
        }

        public void Run()
        {
            Console.WriteLine(Sum());
            Console.WriteLine(Sum(null));
            Console.WriteLine(Sum(1));
            Console.WriteLine(Sum(1, 2, 3, 4, 5));
            Console.WriteLine(Sum(new[] { 1, 2, 3, 4, 5 }));

        }
    }    
}
