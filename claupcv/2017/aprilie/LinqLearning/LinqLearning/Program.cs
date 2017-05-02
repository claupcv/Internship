﻿using System;
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



			Console.ReadKey();
		}
	}
}
