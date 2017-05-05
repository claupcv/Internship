using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLearning
{
	public static class EqualitySequences
	{
		public static void EqualitySequencesMethod()
		{
			Console.WriteLine("EqualitySequencesMethod");

			var set1 = new[] { 1, 2, 3, 5 };
			var set2 = new[] { 2, 1, 5, 3 };
			var set3 = new[] { 1, 2, 3, 5 };

			var areEqual12 = set1.SequenceEqual(set2);
			var areEqual13 = set1.SequenceEqual(set3);

			Console.WriteLine($"set1 SequenceEqual set2: {areEqual12}");
			Console.WriteLine($"set1 SequenceEqual set3: {areEqual13}");

		}
	}
}
