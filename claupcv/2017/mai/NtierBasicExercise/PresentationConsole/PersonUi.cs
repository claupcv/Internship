using DataAccess;
using DataAccess.Repository;
using Models;
using Models.Sorting;
using Presentation.ConsoleUI.Views.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;


namespace PresentationLayerConsole
{
	public class PersonUi
	{
		private readonly IPersonRepository personRepository;

		private readonly IView<SortedCollection<Person, PersonSortCriteria>> personListingView;

		private PersonSortCriteria sortCriteria = PersonSortCriteria.ById;

		private SortDirection sortDirection = SortDirection.Ascending;

		private SortedCollection<Person, PersonSortCriteria> data = null;

		public PersonUi(IPersonRepository personRepository,
			IView<SortedCollection<Person,
			PersonSortCriteria>> personListingView)
		{
			if (personRepository == null)
			{
				throw new ArgumentNullException($"{nameof(personRepository)}");
			}

			if (personListingView == null)
			{
				throw new ArgumentNullException($"{nameof(personListingView)}");
			}

			this.personRepository = personRepository;

			this.personListingView = personListingView;
		}

		
	}
}
