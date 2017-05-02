using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLearning
{
	public static class GroupingOperator
	{

		public static void GroupPersonByYear()
		{
			Console.WriteLine("GroupPersonByYear");
			Person[] persons = Program.CreateMultiplePersons();

			var results = from person in persons
						  group person by person.DateOfBirth.Year into YearGroup
						  orderby YearGroup.Key ascending
						  select YearGroup;

			foreach (var YearGroup in results)
			{
				Console.WriteLine($"(year: {YearGroup.Key})");
				foreach (var item in YearGroup)
				{
					Console.WriteLine($"{item.FirstName} {item.LastName} (d.o.b: {item.DateOfBirth:dd-MM-yyyy})");
				}

			}
		}

		public static void GroupPersonByYearWithExtensions()
		{
			Console.WriteLine("GroupPersonByYearWithExtensions");

			Person[] persons = Program.CreateMultiplePersons();

			var results = persons.GroupBy(p => new { Year = p.DateOfBirth.Year, Month = p.DateOfBirth.Month });

			foreach (var YearGroup in results)
			{
				Console.WriteLine($"(year: {YearGroup.Key.Year} and month = {YearGroup.Key.Month})");
				foreach (var item in YearGroup)
				{
					Console.WriteLine($"{item.FirstName} {item.LastName} (d.o.b: {item.DateOfBirth:dd-MM-yyyy})");
				}

			}
		}
		
	}
}
