using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLearning
{
	public class SelectionOperators
	{
		public static void SelectManyExample()
		{

			Console.WriteLine("SelectManyExample");

			int[] elements = new[] { 1, 2, 3, 4, 5, 6 };

			var result = from element in elements
						 from multipliers in new[] { element * 10, element * 100, element * 50 }
						 select multipliers;
			foreach (int e in result)
			{
				Console.Write(e + ", ");
			}
		}

		public static void SelectManyWithExtensionsExample()
		{

			Console.WriteLine("SelectManyWithExtensionsExample");

			int[] elements = new[] { 1, 2, 3, 4, 5, 6 };

			var result = elements.SelectMany(element => new[] { element * 10, element * 100, element * 50 });

			foreach (int e in result)
			{
				Console.Write(e + ", ");
			}
		}

		public static void SelectManyWithExtensionsConcatenarea2Stringuri()
		{

			Console.WriteLine("SelectManyWithExtensionsConcatenarea2Stringuri");
			int[] set1 = new[] { 1, 4, 5, 3, 8, 9 };
			int[] set2 = new[] { 2, 6, 11, 10 };

			var result = set1.SelectMany(
								e1 => set2,
								(e1, e2) => new Tuple<int, int>(e1, e2))
							  .Where(
								tuple => (tuple.Item1 > 5))
							  .Select(tuple => $"{tuple.Item1}{tuple.Item2}");

			foreach (string e in result)
			{
				Console.Write(e + ", ");
			}

		}
	}
}
