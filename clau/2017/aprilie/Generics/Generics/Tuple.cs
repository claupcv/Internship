using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Tuple<T1, T2>
    {
        public T1 Item1 { get; private set; }

        public T2 Item2 { get; private set; }

        public Tuple(T1 item1, T2 item2)
        {
            this.Item1 = item1;
            this.Item2 = item2;
        }

        public void ShowAttributes()
        {
            Console.WriteLine("Item1 : " + this.Item1.ToString() );
            Console.WriteLine("Item2 : " + this.Item2);
        }
    }
}
