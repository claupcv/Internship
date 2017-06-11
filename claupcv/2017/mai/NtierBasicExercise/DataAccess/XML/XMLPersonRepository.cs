
using DataAccess.Repository;
using Models;
using Models.Extensions;
using Models.IO;
using Models.Sorting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataAccess.XML
{
	public class XmlPersonRepository : IPersonRepository
	{
		private readonly XDocument xmlDocument;

		public XmlPersonRepository(GlobalSettings settings, IPathServices pathServices = null)
	  : this(xmlPath: settings?.RepositoriesConfig?.Xml?.Path, pathServices: pathServices)
		{

		}

		public XmlPersonRepository(string xmlPath, IPathServices pathServices = null)
		{
			if (string.IsNullOrWhiteSpace(xmlPath))
			{
				throw new ArgumentNullException($"{nameof(xmlPath)}");
			}

			if (pathServices != null)
			{
				xmlPath = xmlPath.Replace(PathPlaceholders.CurrentDirectory, pathServices.GetCurrentDirectory());
			}

			if (!File.Exists(xmlPath))
			{
				throw new FileNotFoundException($"XML file cannot be found at path '{xmlPath}'");
			}

			this.xmlDocument = XDocument.Load(xmlPath);

		}

		public Person Add(Person person)
		{
			throw new NotImplementedException();
		}

		public Person Delete(Person person)
		{
			throw new NotImplementedException();
		}

		public Person Edit(Person person)
		{
			throw new NotImplementedException();
		}

		public Person GetPerson(int PersonID)
		{
			throw new NotImplementedException();
		}

		public SortedCollection<Person, PersonSortCriteria> GetPersonSorted(PersonSortCriteria sortCriteria, SortDirection sortDirection)
		{
			IEnumerable<Person> query = from persElement in this.xmlDocument.Descendants("Person")
										let dateOfBirthString = persElement.Element("DateOfBirth")?.Value
										let dateOfBirthFormat = persElement.Element("DateOfBirth") != null ?
																  persElement.Element("DateOfBirth").Attribute("format")?.Value
																  :
																  ""
										select new Person()
										{
											PersonID = int.Parse(persElement.Attribute("PersonID").Value),
											FirstName = persElement.Element("FirstName")?.Value,
											LastName = persElement.Element("LastName")?.Value,
											DateOfBirth = dateOfBirthString.ParseWithFormat(dateOfBirthFormat)
										};

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


			var data = query;

			return new SortedCollection<Person, PersonSortCriteria>(data, sortCriteria, sortDirection);
		}

	}
}
