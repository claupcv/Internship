using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
	public class PersonRepository : Repository<Person>, IPersonRepository
	{
		

		public PersonRepository(PersonContext context)
			:base(context)
		{

		}

		public IEnumerable<Person> GetByName(string text)
		{
			return base.Context.Set<Person>().Where(name=> name.FirstName == text || name.LastName == text ).ToList();
		}
	}
}
