using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class NestedTypes
    {
        public static int Nomber = 1;

        public void test()
        {
            // call the member of inside class
            Nested.numbersss = 1;
        }
        public class Nested
        {
            public static int numbersss;
            public NestedTypes parent;

            public Nested()
            {
            }
            public Nested(NestedTypes parent)
            {
                this.parent = parent;

                // calling the member of outside class
                NestedTypes.Nomber = 2;
            }
        }
    }
    public static class RunNestedTypes
    {
        public static void RunNestedTypesMethod()
        {
            NestedTypes.Nested nest = new NestedTypes.Nested();
        }
        
    }
}
