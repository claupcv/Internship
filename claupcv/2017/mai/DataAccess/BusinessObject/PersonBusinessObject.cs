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
		// for SQL
		//private PersonRepository personRepository = new PersonRepository(new DataBaseContext());
		
		// for XML
		private XMLPersonRepository personRepository = new XMLPersonRepository(new XMLContext());
		public PersonRepository GetPersonByName(string name)
		{

			var personData = personRepository.GetByName(name);

			foreach (var person in personData)
			{
				Console.WriteLine($"PersonID: {person.PersonID}, Name: {person.FirstName} {person.LastName}, DOB: {person.DateOfBirth.ToShortDateString()}");
			}


				return personRepository;
		}
    }
}
