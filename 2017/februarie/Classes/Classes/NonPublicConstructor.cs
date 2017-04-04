using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    /// <summary>
    /// Example of private contructor handlede by static methods
    /// </summary>
    class NonPublicConstructor
    {
        private int min;
        private int max;

        private NonPublicConstructor(int min, int max)
        {
            this.min = min;
            this.max = max;
        }

        public static NonPublicConstructor Between(int max, int min)
        {
            return new NonPublicConstructor(min, max);
        }

        public static NonPublicConstructor BiggerThan(int min)
        {
            return new NonPublicConstructor(min, int.MaxValue);
        }

        public static NonPublicConstructor SmallerThan(int max)
        {
            return new NonPublicConstructor(int.MinValue, max);
        }
 
        public int next() 
        {
            Random rnd = new Random();
            if (min < max) {
                return rnd.Next(min,max);
            }
            else
            {
                return rnd.Next(max, min);
            }
        }
    }
}
