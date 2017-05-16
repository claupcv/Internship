using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;

namespace BusinessObject
{
    public class PersonBusinessObject
	{
		private PersonRepository personRepository;
		private PersonContext personContext = new PersonContext();

		public PersonBusinessObject()
		{
			personRepository = new PersonRepository(personContext);
		}

		public PersonRepository GetPersonByName(string name)
		{
			PersonRepository personRepository = new PersonRepository(personContext);

			var personData = personRepository.GetByName(name);

			foreach (var person in personData)
			{
				Console.WriteLine($"PersonID: {person.PersonID}, Name: {person.FirstName} {person.LastName}, DOB: {DateTime.Now-person.DateOfBirth}");
			}


				return personRepository;
		}
    }
}
