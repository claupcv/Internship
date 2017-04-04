using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class StaticConstructor
    {
        static StaticConstructor()
        {
            StaticConstructor.Startup = DateTime.Now;
        }
 
        public static DateTime Startup { get; private set; }
    }
}
