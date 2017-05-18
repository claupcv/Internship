using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Entity.Infrastructure;

namespace DataAccess
{
	public class DataBaseContext : DbContext
	{
		public DataBaseContext()
		   : base("name=PersonAppConnectionString")
		{
			this.Configuration.LazyLoadingEnabled = true;
		}
		
		public DbSet<Person> Persons { get; set; }		
	}
}

