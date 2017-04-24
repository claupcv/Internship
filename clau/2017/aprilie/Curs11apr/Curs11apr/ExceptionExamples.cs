using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs11apr
{
    public static class ExceptionExamples
    {
        private static void WriteExceptionDetails(Exception e)
        {
            Console.WriteLine("Message : {0}", e.Message);
            Console.WriteLine("StackTrace : {0}", e.StackTrace);
            Console.WriteLine("Type : {0}", e.GetType());

            if (e.InnerException != null)
            {
                WriteExceptionDetails(e.InnerException);
            }
        }

        public static void MethodThatEncuntersAnException(Person p)
        {

            try
            {
                //cod succeptibil de erori
                Console.WriteLine(p.FirstName);
            }
            catch (Exception e)
            {
                WriteExceptionDetails(e);
                //cod de tratare a erorilor

            }
            finally
            {
                Console.WriteLine("FINALY : To timpul se afiseaza");

            }

        }
    }
}
