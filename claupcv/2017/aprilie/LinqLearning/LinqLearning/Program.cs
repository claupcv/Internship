using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLearning
{
	class Program
	{
		private static Person[] CreateMultiplePersons()
		{
			var persons = new Person[]
			{
			  new Person()
			  {
				FirstName = "John",
				LastName = "Doe",
				DateOfBirth = new DateTime(2005, 3, 25)
			  },
			  new Person()
			  {
				FirstName = "Marry",
				LastName = "Joe",
				DateOfBirth = new DateTime(2005, 7, 15)
			  },
			  new Person()
			  {
				FirstName = "Bill",
				LastName = "Smith",
				DateOfBirth = new DateTime(2010, 11, 2)
			  },
			  new Person()
			  {
				FirstName = "Lisa",
				LastName = "Davis",
				DateOfBirth = new DateTime(1910, 1, 17)
			  },
			  new Person()
			  {
				FirstName = "Clau",
				LastName = "PCV",
				DateOfBirth = new DateTime(1980, 2, 2)
			  }
			};

			return persons;
		}
		private static void PersonNONLinqExample()
		{

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

		private static void PersonLinqExample()
		{
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

		private static void PersonLinqWIthExtensionsExample()
		{
			Person[] persons = Program.CreateMultiplePersons();

			var results = persons.Where<Person>(p =>((DateTime.Today.Year-p.DateOfBirth.Year) >18 ) && (p.LastName.StartsWith("D"))).ToList();

			Console.WriteLine("LINQ With Extension: The list of persons over 18 years old and with last-name starting with 'D' is:");
						
			foreach (var item in results)
			{
				Console.WriteLine($"{item.FirstName} {item.LastName} (d.o.b: {item.DateOfBirth:dd-MM-yyyy})");

			}
		}

		private static void OfTypeExample()
		{
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

		private static void SelectManyExample()
		{
			int[] elements = new[] { 1, 2, 3, 4, 5, 6 };

			var result = from element in elements
						 from multipliers in new[] { element * 10, element * 100, element * 50 }
						 select multipliers;
			foreach (int e in result)
			{
				Console.Write(e + ", ");
			}
		}

		private static void SelectManyWithExtensionsExample()
		{
			int[] elements = new[] { 1, 2, 3, 4, 5, 6 };

			var result = elements.SelectMany(element => new[] { element * 10, element * 100, element * 50 });

			foreach (int e in result)
			{
				Console.Write(e + ", ");
			}
		}

		private static void SelectManyWithExtensionsConcatenarea2Stringuri()
		{
			int[] set1 = new[] { 1, 4, 5, 3, 8, 9 };
			int[] set2 = new[] { 2, 6, 9, 3 };



			var result = set1.SelectMany(
								e1 => set2,
								(e1, e2) => new Tuple<int, int>(e1, e2))
							  .Where(
								tuple => (tuple.Item1 == tuple.Item2 - 1) ||
										  (tuple.Item1 == tuple.Item2 + 1))
							  .Select(tuple => $"{tuple.Item1}{tuple.Item2}");

			foreach (string e in result)
			{
				Console.Write(e + ", ");
			}

		}
		static void Main(string[] args)
		{
			Program.PersonNONLinqExample();
			Console.WriteLine("===============================================================");

			Program.PersonLinqExample();
			Console.WriteLine("===============================================================");

			Program.PersonLinqWIthExtensionsExample();
			Console.WriteLine("===============================================================");

			Program.OfTypeExample();
			Console.WriteLine("===============================================================");

			Program.SelectManyExample();
			Console.WriteLine("===============================================================");

			Program.SelectManyWithExtensionsExample();
			Console.WriteLine("===============================================================");


			Program.SelectManyWithExtensionsConcatenarea2Stringuri();
			Console.WriteLine("===============================================================");
			Console.ReadKey();
		}
	}
}
