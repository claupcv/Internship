using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Exceptions
{
    class NotImplementedExceptionExample : System.Exception
    {
        public static string GetNameOfDay(DayOfWeek dw)
        {
            switch (dw)
            {
                case DayOfWeek.Monday:
                    return "Monday";
                case DayOfWeek.Tuesday:
                    return "Tuesday";
                case DayOfWeek.Wednesday:
                    return "Wednesday";
                case DayOfWeek.Thursday:
                  return "Thursday";
                case DayOfWeek.Friday:
                    return "Friday";
                case DayOfWeek.Saturday:
                    return "Saturday";
                default:
                    throw new NotImplementedException("The case for value " + dw + " of type '" + typeof(DayOfWeek) + "' is not implemented");


              
          }
        }
    }
}
