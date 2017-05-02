using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLearning
{
	class DataCollectionOperator
	{
		public static void UnionWithExtensions()
		{
			Console.WriteLine("UnionWithExtensions");

			var set1 = new[] { 1, 2, 3, 3, 4, 5 };
			var set2 = new[] { 2, 4, 6, 8, 10 };

			var results = set1.Union(set2);

			foreach (int element in results)
			{
				Console.Write(element + ", ");
			}
		}

		public static void DefaultIfEmptyWithExtensions()
		{
			Console.WriteLine("DefaultIfEmptyWithExtensions");

			var set1 = new[] { 1, 2, 3, 3, 4, 5 };

			var result1 = set1.DefaultIfEmpty();

			// Outputs:
			// Set 1: 1,2,3,4
			Console.WriteLine(
			  "Set 1: {0}",
			  string.Join(",", result1.Select(elem => elem.ToString())));


			int[] set2 = new int[] { };
			var result2 = set2.DefaultIfEmpty();
			// Outputs:
			// Set 2: 0
			Console.WriteLine(
			  "Set 2: {0}",
			  string.Join(",", result2.Select(elem => elem.ToString())));

		}

		public static void ZipWithExtensions()
		{
			Console.WriteLine("ZipWithExtensions - diferentza este ca SelectMany face produs cartezian");

			string[] set1 = new[] { "Item 1", "Item 2", "Item 3" };
			int[] set2 = { 1, 2, 3, 4, 5 };

			var zipResult = set1.Zip(set2, (str, nr) => $"{nr} - {str}");
			Console.WriteLine("Zip result:");
			foreach (string s in zipResult)
			{
				Console.WriteLine(s);
			}

		}
	}
}
