using DataAccess.Repository;
using Models;
using Models.Sorting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.InMemory
{
	public class InMemoryPersonRepository : IPersonRepository
  {
    private static readonly List<Person> personsCollection = new List<Person>();

    public InMemoryPersonRepository()
      : this(InMemoryPersonRepository.DefaultDataSetInitialization)
    {

    }

    public InMemoryPersonRepository(Func<IEnumerable<Person>> dataSetInitialization)
    {
      if (InMemoryPersonRepository.personsCollection.Count == 0)
      {
        if (dataSetInitialization != null)
        {
          var initialSet = dataSetInitialization();

          if (initialSet != null)
          {
            InMemoryPersonRepository.personsCollection.AddRange(initialSet);
          }
        }
      }
    }

		SortedCollection<Person, PersonSortCriteria> GetPersonSorted(PersonSortCriteria sortCriteria, SortDirection sortDirection)
    {
      IEnumerable<Person> query = InMemoryPersonRepository.personsCollection;

      switch (sortCriteria)
      {
        case PersonSortCriteria.ById:
        default:
          switch (sortDirection)
          {
            case SortDirection.Ascending:
            default:
              query = query.OrderBy(p => p.PersonID);
              break;

            case SortDirection.Descending:
              query = query.OrderByDescending(p => p.PersonID);
              break;
          }
          break;

        case PersonSortCriteria.ByFirstName:
          switch (sortDirection)
          {
            case SortDirection.Ascending:
            default:
              query = query.OrderBy(p => p.FirstName);
              break;

            case SortDirection.Descending:
              query = query.OrderByDescending(p => p.FirstName);
              break;
          }
          break;

        case PersonSortCriteria.ByLastName:
          switch (sortDirection)
          {
            case SortDirection.Ascending:
            default:
              query = query.OrderBy(p => p.LastName);
              break;

            case SortDirection.Descending:
              query = query.OrderByDescending(p => p.LastName);
              break;
          }
          break;

        case PersonSortCriteria.ByBirthDate:
          switch (sortDirection)
          {
            case SortDirection.Ascending:
            default:
              query = query.OrderBy(p => p.DateOfBirth);
              break;

            case SortDirection.Descending:
              query = query.OrderByDescending(p => p.DateOfBirth);
              break;
          }
          break;
      }

      int totalRecordsCount = query.Count();

      var data = query;

      return new SortedCollection<Person, PersonSortCriteria>(data, sortCriteria, sortDirection);
    }

    private static IEnumerable<Person> DefaultDataSetInitialization()
    {
      List<Person> persons = new List<Person>();
      var randomGen = new Random();

      for (int i = 0; i < 100; i++)
      {
        var person = new Person()
        {
          PersonID = i + 1,
          FirstName = "Generated",
          LastName = "Person " + (i + 1),
          DateOfBirth = new DateTime(
                          year: 1970 + randomGen.Next(0, 40),
                          month: randomGen.Next(1, 12),
                          day: randomGen.Next(1, 28))
        };

        persons.Add(person);
      }

      return persons;
    }

		SortedCollection<Person, PersonSortCriteria> IPersonRepository.GetPersonSorted(PersonSortCriteria sortCriteria, SortDirection sortDirection)
		{
			throw new NotImplementedException();
		}
	}
}
