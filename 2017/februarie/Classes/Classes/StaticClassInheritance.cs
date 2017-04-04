using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    // cannot make static class to be inherited (static class ParentStatic)
    // cannot be inherited by a static class
    // inheritance does not allow (parent and child to be static)
    // why?
    // ParentClass static : no polimorfism, no code reuse
    // static class inherits from type object
    public static class ParentStatic
    {
         protected static void ParentMethod(){

        }
    }

    public  static class Child : ParentStatic
    {

    }
}
