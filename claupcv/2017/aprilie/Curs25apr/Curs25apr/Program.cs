using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs25apr
{
	class Program
	{
		static void Main(string[] args)
		{
			var collection = new CustomCollection<int>(1, 2, 3);

			Console.WriteLine(collection.Contains(2)); 
			var evenEnum = new ConditionalCustomCollection<int>(collection, new NumberIsOdd());
			foreach (var item in evenEnum)
			{
				Console.WriteLine(item);
			}

			var oddCollection = collection.ApplyCondition(new NumberIsOdd()).ApplyCondition(new NumberIsLesThan(2));

			Console.WriteLine("----------------------------------");
			

			foreach (var element in collection)
			{
				Console.WriteLine(element);
			}



			//using (var iterator = collection.GetEnumerator())
			//{

			//	Console.WriteLine("Iterator start");
			//	while (iterator.MoveNext())
			//	{
			//		Console.WriteLine(iterator.Current);
			//	}
			//}

			Console.WriteLine("Stop....");

			Console.ReadKey();
		}
	}
}
