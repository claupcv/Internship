using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// namespaces objetcs that encapsulates clases and other namespaces
namespace HelloWorld
{
        // class or struct
        public static class ObjectElementss
        {
            // a class have private static Fields(membra clasei)
            private static int privateField = 0;

            private static int numberss = 10;

            public static int Numbertemp { get; set; }
            public static int Number 
            { 
                get
                {
                    return numberss;
                } 
                set
                {
                    numberss = value;
                } 
            }

            public static int protertyOfClass { get; set; }

            // public method can be with no return(in this case use void) or can return a value(use type of the return eg.:int)
            public static void PublicNoReturnMethod()
            {
                // variabila clasei 
                int whatIsThis = 0;
                numberss = 1;
                whatIsThis = whatIsThis + 1;
                privateField = privateField + 1;
            }
        }

        public static class Propertiess
        {
            public static void PropertiesMethod()
            {
                //ObjectElementss.Number = 1;
                Console.WriteLine(ObjectElementss.Number);
            }
          
        }


}