using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLearning
{
	public static class QuantifiersOperators
	{
		public static void  AnyOperator()
		{
			Console.WriteLine("AnyOperator");

			var set1 = new int[] { };
			var result1 = set1.Any();
			Console.WriteLine($"Any elements in 1'st collection: {result1}");

			var set2 = new int[] { 1, 2, 3 };
			var result2 = set2.Any();
			Console.WriteLine($"Any elements in 2'nd collection: {result2}");

			var result3 = set2.Any(e => e % 2 == 0);
			Console.WriteLine($"Any even elements in 2'nd collection: {result3}");
		}

		public static void AllOperator()
		{
			Console.WriteLine("AnyOperator");

			var set1 = new[] { 1, 2, 3, 5 };
			var allAreEven = set1.All(e => e % 2 == 0);
			Console.WriteLine($"All elements in 1'st collection are even: {allAreEven}");
		}

		}
}
