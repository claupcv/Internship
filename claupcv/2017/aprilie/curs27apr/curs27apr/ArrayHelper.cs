using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curs27apr
{
	public static class ArrayHelper
	{
		public static T[] Sum<T>(T[] array1, T[] array2, Func<T, T, T> sum)
		{
			if (array1 == null)
			{
				array1 = new T[0];
			}

			if (array2 == null)
			{
				array2 = new T[0];
			}

			if (sum == null)
			{
				throw new ArgumentNullException(nameof(sum));
			}

			if(array1.Length != array2.Length)
			{
				throw new ArgumentException($"Aray size mismatch array1: {array1.Length} and array2 : {array2.Length}");
			}

			T[] result = new T[array1.Length];

			for (int i = 0; i < array1.Length; i++)
			{
				result[i] = sum(array1[i], array2[i]);
			}

			return result;
		}
	}
}
