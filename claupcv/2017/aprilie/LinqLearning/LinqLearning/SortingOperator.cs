using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLearning
{
	public static class SortingOperator
	{
		public static void OrderBy()
		{

			Console.WriteLine("OrderBy");
			Person[] persons = Program.CreateMultiplePersons();
			var results = from person in persons
						 orderby person.DateOfBirth ascending,
								  person.FirstName ascending
						 select person;


			foreach (var item in results)
			{
				Console.WriteLine($"{item.FirstName} {item.LastName} (d.o.b: {item.DateOfBirth:dd-MM-yyyy})");

			}
		}

		public static void OrderByThenByWithExtensions()
		{

			Console.WriteLine("OrderByThenByWithExtensions");
			Person[] persons = Program.CreateMultiplePersons();
			var results = persons.Where(p => p.DateOfBirth.Year>1990).OrderByDescending(p => p.DateOfBirth)
						  .ThenBy(p => p.DateOfBirth)
						  .ThenBy(p => p.FirstName);


			foreach (var item in results)
			{
				Console.WriteLine($"{item.FirstName} {item.LastName} (d.o.b: {item.DateOfBirth:dd-MM-yyyy})");

			}
		}
	}
}
