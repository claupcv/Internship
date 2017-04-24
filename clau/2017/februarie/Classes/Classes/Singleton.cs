using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    /// <summary>
    /// Allows to instace only 1 instance (no more)
    /// </summary>
    public sealed class Singleton
    {
        static readonly Singleton _instance = new Singleton();
        public static Singleton Instance
        {
            get
            {
                return _instance;
            }
        }
        Singleton()
        {
            Console.WriteLine("instance");
        }        
    }
}
