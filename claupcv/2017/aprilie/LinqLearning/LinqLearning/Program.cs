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
		public static Person[] CreateMultiplePersons()
		{
			var persons = new Person[]
			{
			  new Person()
			  {
				FirstName = "John",
				LastName = "Doe",
				DateOfBirth = new DateTime(2005, 7, 25)
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


		public static Department[] CreateMultipleDepartments()
		{
			var departments = new[]
			{
			  new Department { Id = 1, Name = "Administrative" },
			  new Department { Id = 2, Name = "HR" },
			  new Department { Id = 3, Name = "Financial" },
			  new Department { Id = 4, Name = "Programming" }
			};

			return departments;
		}

		public static Employee[] CreateMultipleEmployees()
		{
			var employees = new[]
			{
			  new Employee { Id = 1, Name = "John Doe", DepartmentId = 1 },
			  new Employee { Id = 2, Name = "Henry Joe", DepartmentId = 2 },
			  new Employee { Id = 3, Name = "Marry Joe", DepartmentId = 3 },
			  new Employee { Id = 4, Name = "Bill Smith", DepartmentId = 4 },
			  new Employee { Id = 5, Name = "Lisa Davis", DepartmentId = 4 },
			};

			return employees;
		}

		static void Main(string[] args)
		{
			FilteringOperators.PersonNONLinqExample();
			Console.WriteLine("===============================================================");

			FilteringOperators.PersonLinqExample();
			Console.WriteLine("===============================================================");

			FilteringOperators.PersonLinqWIthExtensionsExample();
			Console.WriteLine("===============================================================");

			FilteringOperators.OfTypeExample();
			Console.WriteLine("===============================================================");


			SelectionOperators.SelectManyExample();
			Console.WriteLine("===============================================================");

			SelectionOperators.SelectManyWithExtensionsExample();
			Console.WriteLine("===============================================================");

			SelectionOperators.SelectManyWithExtensionsConcatenarea2Stringuri();
			Console.WriteLine("===============================================================");


			SortingOperator.OrderBy();
			Console.WriteLine("===============================================================");

			SortingOperator.OrderByThenByWithExtensions();
			Console.WriteLine("===============================================================");


			GroupingOperator.GroupPersonByYear();
			Console.WriteLine("===============================================================");

			GroupingOperator.GroupPersonByYearWithExtensions();
			Console.WriteLine("===============================================================");


			PartitioningOperators.TakeWhileExampleWithExtensions();
			Console.WriteLine("===============================================================");

			PartitioningOperators.SkipWhileExampleWithExtensionsAndPersonsOnMultiplePages();
			Console.WriteLine("===============================================================");

			PartitioningOperators.SkipWhileExampleWithExtensionsAndPersonsOnMultiplePages();
			Console.WriteLine("===============================================================");


			DataCollectionOperator.UnionWithExtensions();
			Console.WriteLine("===============================================================");

			DataCollectionOperator.DefaultIfEmptyWithExtensions();
			Console.WriteLine("===============================================================");

			DataCollectionOperator.ZipWithExtensions();
			Console.WriteLine("===============================================================");


            ReturnElementsOperators.ReturnFirstOrDefaultOperator();
            Console.WriteLine("===============================================================");

            ReturnElementsOperators.ReturnElementAtOperator();
            Console.WriteLine("===============================================================");


			QuantifiersOperators.AnyOperator();
			Console.WriteLine("===============================================================");

			QuantifiersOperators.AllOperator();
			Console.WriteLine("===============================================================");


			EqualitySequences.EqualitySequencesMethod();
			Console.WriteLine("===============================================================");


			JoinStatement.JoinStatementMethod();
			Console.WriteLine("===============================================================");

			JoinStatement.JoinStatementWEithExtensions();
			Console.WriteLine("===============================================================");

			JoinStatement.GroupJoinStatementMethod();
			Console.WriteLine("===============================================================");


			ConversionFunctions.AsEnumerableMethod();
			Console.WriteLine("===============================================================");

			ConversionFunctions.CastMethod();
			Console.WriteLine("===============================================================");

			Console.ReadKey();
		}
	}
}
