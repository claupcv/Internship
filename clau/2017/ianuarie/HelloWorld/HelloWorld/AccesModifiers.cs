using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    using System.ComponentModel.Design;

    public class AccesModifiers
    {
        
            
        
        //check constant
        protected const int Value= 1;

        protected static int ID = 0;
    }

    public class TestAM  : AccesModifiers
    {
        public static void TestAMmethod()
        {
            AccesModifiers.ID=1;
            Console.WriteLine(AccesModifiers.Value);
            
        }
    }
}
