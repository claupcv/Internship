using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs09mai
{
	class Program
	{
		static void Main(string[] args)
		{
			var array = new[] {1, 2, 3, 4, 5, 6, 7};

			var queryEven = array.Where((int elem ) => { return elem % 2 != 0});


			int[] set1 = new[] { 1, 4, 5, 3, 8, 9 };
			int[] set2 = new[] { 2, 6, 9, 3 };


			var result = set1.SelectMany(
					e1 => set2,
					(e1, e2) => new Tuple<int, int>(e1, e2))
				  .Where(
					tuple => (tuple.Item1 == tuple.Item2 - 1) ||
							  (tuple.Item1 == tuple.Item2 + 1))
				  .Select(tuple => $"{tuple.Item1}{tuple.Item2}");

			foreach (int e in result)
			{
				Console.Write(e + ", ");
			}


			foreach (string e in result)
			{
				Console.Write($"{e.}");
			}

		}
	}
}
