using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
	public class XMLPersonRepository : XMLRepository<Person>, IPersonRepository
	{
		public XMLPersonRepository(XMLContext context)
			: base(context)
		{
		}

		public IEnumerable<Person> GetByName(string text)
		{
			return this.Persons.Where(name => name.FirstName == text || name.LastName == text).ToList();
		}

		public XMLContext XMLContext
		{
			get { return Context as XMLContext; }
		}
	}
}
