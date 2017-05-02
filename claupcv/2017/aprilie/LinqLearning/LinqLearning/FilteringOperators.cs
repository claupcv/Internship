using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLearning
{
	public static class FilteringOperators
	{
		
		public static void PersonNONLinqExample()
		{
			Console.WriteLine("PersonNONLinqExample");
			Person[] persons = Program.CreateMultiplePersons();
			List<Person> results = new List<Person>();
			foreach (var person in persons)
			{
				var over18years = (DateTime.Today.Year - person.DateOfBirth.Year) >= 18;
				var lastNameStartsWithD = person.LastName.StartsWith("D");
				if (over18years && lastNameStartsWithD)
				{
					results.Add(person);
				}
			}

			Console.WriteLine("NON LINQ: The list of persons over 18 years old and with last-name starting with 'D' is:");
			foreach (var item in results)
			{
				Console.WriteLine($"{item.FirstName} {item.LastName} (d.o.b: {item.DateOfBirth:dd-MM-yyyy})");

			}
		}

		public static void PersonLinqExample()
		{
			Console.WriteLine("PersonLinqExample");
			Person[] persons = Program.CreateMultiplePersons();
			var results =
						  from person in persons
						  let over18years = (DateTime.Today.Year - person.DateOfBirth.Year) >= 18
						  let lastNameStartsWithD = person.LastName.StartsWith("D")
						  where over18years && lastNameStartsWithD
						  select person;
			Console.WriteLine("LINQ : The list of persons over 18 years old and with last-name starting with 'D' is:");
			foreach (var item in results)
			{
				Console.WriteLine($"{item.FirstName} {item.LastName} (d.o.b: {item.DateOfBirth:dd-MM-yyyy})");

			}

		}

		public static void PersonLinqWIthExtensionsExample()
		{
			Console.WriteLine("PersonLinqWIthExtensionsExample");

			Person[] persons = Program.CreateMultiplePersons();

			var results = persons.Where<Person>(p => ((DateTime.Today.Year - p.DateOfBirth.Year) > 18) && (p.LastName.StartsWith("D"))).ToList();

			Console.WriteLine("LINQ With Extension: The list of persons over 18 years old and with last-name starting with 'D' is:");

			foreach (var item in results)
			{
				Console.WriteLine($"{item.FirstName} {item.LastName} (d.o.b: {item.DateOfBirth:dd-MM-yyyy})");

			}
		}

		public static void OfTypeExample()
		{
			Console.WriteLine("OfTypeExample");

			ArrayList arr = new ArrayList();
			arr.Add(1);
			arr.Add("test");
			arr.Add(new Person() { FirstName = "Clau", LastName = "PCV" });
			arr.Add("another text");

			var strings = arr.OfType<string>();
			foreach (string str in strings)
			{
				Console.WriteLine(str);
			}
		}
	}
}
