using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public static class  OverloadMethods
    {
        // method with 2 param, and return void(no return)
        public static void Message(string message)
        {
            Console.WriteLine(message);
        }

        public static void Message(string message, int count)
        {
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    OverloadMethods.Message(message);
                }
            }

        }
    }
}
