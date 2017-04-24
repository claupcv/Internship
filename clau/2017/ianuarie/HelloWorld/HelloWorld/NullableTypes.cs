using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class NullableTypes
    {
        public static void NullableTypeMethod()
        {
            bool? nullAtribute = null;
            bool attribute=true;
            
            //from here

            if (nullAtribute != null)
            {
                Console.WriteLine("yes");
            }
            else 
            {
                attribute = (bool)nullAtribute.Value;
            }
            // to here 
            //or we can do :  
            attribute = nullAtribute ?? false; //0 being the default value of null

            Console.WriteLine(attribute);

        }
    }
}
