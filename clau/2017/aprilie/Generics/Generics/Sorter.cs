using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Sorter<T>
        where T : struct, IComparable<T>
    {
        protected readonly T[] elements;

        public Sorter(params T[] elements)
        {
            if (elements == null)
            {
                elements = new T[] { };
            }

            this.elements = elements;
        }

        public T[] SortAscending()
        {
            for (int i = 0; i < this.elements.Length; i++)
            {
                for (int j = i + 1; j < this.elements.Length; j++)
                {
                    // IComparable<T> exposes CompareTo(a, b) method
                    // which returns the following values:
                    // a) Negative (strictly), when a < b
                    // b) Zero, when a = b
                    // c) Positive (strictly), when a > b
                    if (this.elements[i].CompareTo(this.elements[j]) > 0)
                    {
                        // this means: elements[i] > elements[j]
                        // we swap:
                        var aux = this.elements[i];
                        this.elements[i] = this.elements[j];
                        this.elements[j] = aux;
                    }
                }
            }
            return this.elements;
        }
    }
}
