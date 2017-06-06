using Models;
using Models.Sorting;

using Presentation.ConsoleUI.Views.Abstractions;
using System;

namespace Presentation.ConsoleUI.Views.Implementation
{
	public class PersonListingView : IView<SortedCollection<Person, PersonSortCriteria>>
	{
		public void Render(SortedCollection<Person, PersonSortCriteria> data)
		{
			Console.Clear();

			var collectionArray = data.Data;

			if ((collectionArray != null))
			{
				foreach (var element in collectionArray)
				{
					Console.WriteLine($"PersonID:{element.PersonID} , " +
						$"FirstName:{element.FirstName} , " +
						$"LastName:{element.LastName} , " +
						$"DateOfBirth:{element.DateOfBirth} ");
				}
			}
			else
			{
				Console.WriteLine("Curent collectionArray is Null");
			}

		}

		private string GetSortCriteriaString(PersonSortCriteria sortCriteria)
		{
			switch (sortCriteria)
			{
				default:
				case PersonSortCriteria.ById:
					return "by id";

				case PersonSortCriteria.ByFirstName:
					return "by first name";

				case PersonSortCriteria.ByLastName:
					return "by last name";

				case PersonSortCriteria.ByBirthDate:
					return "by birth date";
			}
		}

		private string GetSortDirectionString(SortDirection sortDirection)
		{
			switch (sortDirection)
			{
				default:
				case SortDirection.Ascending:
					return "ascending";

				case SortDirection.Descending:
					return "descending";
			}
		}
	}
}
