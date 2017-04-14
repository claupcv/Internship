using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs11apr
{
    public static class DynamicType
    {

        public static dynamic CreateDinamic()
        {
            dynamic obj = new System.Dynamic.ExpandoObject();

            obj.FirstName = "John";

            obj.FirstName = 10 + obj.FirstName;

            obj.SayHello = (Action)delegate() { Console.WriteLine("Hello"); };

            return obj;
        }

        public static void ReadDinamic(dynamic obj)
        {
            Console.WriteLine(obj.FirstName);

            obj.SayHello();
        }
    }
}
