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
using DataAccess.Database;

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

		public Person DeletePersonBusiness(Person person)
		{
			return this.personsRepository.Delete(person);
		}

		public Person EditPerson(EditPersonDTO EditModel)
		{
			if (EditModel == null)
			{
				throw new Exception();
			}

			return this.personsRepository.Edit(
				new Person
				{
					PersonID = EditModel.PersonID,
					FirstName = EditModel.FirstName,
					LastName = EditModel.LastName,
					DateOfBirth = EditModel.DateOfBirth
				});
		}

		public Person GetPersonBusiness (int PersonID)
		{ 

			Person person = personsRepository.GetPerson(PersonID);
			return person;
				
		}
	}
}
