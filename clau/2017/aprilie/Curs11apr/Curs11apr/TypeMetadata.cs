using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs11apr
{
    public static class TypeMetadata
    {
        public static bool IsInteger(object parameter)
        {
            if (parameter == null)
            {
                return false;
            }

            Type typeOfparameter = parameter.GetType();

            return typeOfparameter == typeof(int);
        }

    }
}
