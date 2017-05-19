using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
	public class PersonRepository : Repository<Person>
	{
		//ctor database
		public PersonRepository(DataBaseContext context)
			:base(context)
		{
		}

		public IEnumerable<Person> GetByName(string text)
		{
			return this.DataContext.Persons.Where(name=> name.FirstName == text || name.LastName == text ).ToList();
		}

		public DataBaseContext DataContext
		{
			get { return Context as DataBaseContext; }
		}
	}
}
