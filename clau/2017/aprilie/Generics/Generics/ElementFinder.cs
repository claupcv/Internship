using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class ElementFinder<T>
    {
        private readonly T[] elements;

        public ElementFinder(params T[] elements)
        {
            if (elements == null)
            {
                elements = new T[] { };
            }

            this.elements = elements;
        }

        public bool FindByIndex(int index, out T element)
        {
            // since this is an out parameter
            // we must initialize it in this method
            // regardless of whether it is found in the array or not
            //element = default(T);
            if ((index >= 0) && (index < this.elements.Length))
            {
                element = this.elements[index];
                return true;
            }
            else
            {
                element = default(T);
            }

            // index points outside of the bounds of the array
            return false;
        }
    }
}
