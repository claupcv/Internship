using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLearning
{
	class PartitioningOperators
	{
		public static void TakeWhileExampleWithExtensions()
		{

			Console.WriteLine("TakeWhileExampleWithExtensions");

			Person[] persons = Program.CreateMultiplePersons();

			var results = persons.OrderBy(p => p.DateOfBirth.Year)
				.TakeWhile(p => p.DateOfBirth.Year >=1985);

			foreach (var item in results)
			{
				Console.WriteLine($"{item.FirstName} {item.LastName} (d.o.b: {item.DateOfBirth:dd-MM-yyyy})");

			}
		}
	

		public static void SkipWhileExampleWithExtensionsAndPersonsOnMultiplePages()
		{

			Console.WriteLine("SkipWhileExampleWithExtensionsAndPersonsOnMultiplePages");

			Person[] persons = Program.CreateMultiplePersons();

			var pageSize = 3;

			int totalPersons = persons.Count();

			int totalPages = totalPersons / pageSize + (totalPersons % pageSize > 0 ? 1 : 0);

			for (int pageNo = 1; pageNo <= totalPages; pageNo++)
			{
				var pageIndex = pageNo - 1;

				var results = persons.Skip(pageIndex * pageSize).Take(pageSize);

				Console.WriteLine($"Page: {pageNo}");
				foreach (var person in results)
				{
					Console.WriteLine($"{person.FirstName} {person.LastName} (d.o.b: {person.DateOfBirth:dd-MM-yyyy})");
				}



			}

		}
	}
}
