using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
	public class PersonContext : DbContext
	{
		public PersonContext()
		   : base("name=PersonAppConnectionString")
		{
			this.Configuration.LazyLoadingEnabled = false;
		}
		public DbSet Person { get; set; }
	}
}

