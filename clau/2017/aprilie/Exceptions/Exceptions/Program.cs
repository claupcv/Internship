using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            MultipleExceptions.MultiExceptionExample();

            NotImplementedExceptionExample.GetNameOfDay(DayOfWeek.Sunday);
            Console.ReadKey();
        }
    }
}
