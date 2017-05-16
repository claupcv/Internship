using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
	public class Person
	{
		public int PersonID { get; set; } = 0;

		public string FirstName { get; set; } = "";

		public string LastName { get; set; } = "";

		public DateTime DateOfBirth { get; set; } = DateTime.MinValue;
	}
}
