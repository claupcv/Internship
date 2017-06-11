using DataAccess.Repository;
using Models.Sorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;
using Models;
using Models.CRUD;

namespace BusinessObject
{
    public class PersonBusinessObject
	{
		private readonly IPersonRepository personsRepository;

		public PersonBusinessObject(IPersonRepository personsRepository)
		{
			if (personsRepository == null)
			{
				throw new ArgumentNullException($"{nameof(personsRepository)}");
			}

			this.personsRepository = personsRepository;
		}

		public SortedCollection<Person, PersonSortCriteria> GetPersonsPaged(PersonSortCriteria sortCriteria, SortDirection sortDirection)
		{
			return this.personsRepository.GetPersonSorted(sortCriteria, sortDirection);
		}

		public Person AddPerson(CreatePersonDTO CreateModel)
		{
			if(CreateModel == null)
			{
				throw new Exception();
			}

			return this.personsRepository.Add(
				new Person {
					FirstName = CreateModel.FirstName,
					LastName = CreateModel.LastName,
					DateOfBirth = CreateModel.DateOfBirth
				});
		}

		public Person DeletePerson(Person person)
		{
			return this.personsRepository.Delete(person);
		}

		public Person EditPerson(Person person)
		{
			return this.personsRepository.Edit(person);
		}
	}
}
