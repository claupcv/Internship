using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public static class EqualityChecker
    {
        public static bool AreEqual<T,T2>(T element1, T2 element2)
        {
            if (object.ReferenceEquals(element1, null) &&
                   object.ReferenceEquals(element2, null))
            {
                // both elements are null
                return true;
            }

            if (object.ReferenceEquals(element1, null) ||
                   object.ReferenceEquals(element2, null))
            {
                // one of the element is null, but not both
                return false;
            }

            // use type T's Equals implementation for equality check
            return element1.Equals(element2);
        }
    }
}
