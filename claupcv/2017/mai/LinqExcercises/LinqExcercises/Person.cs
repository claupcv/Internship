using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExcercises
{
	public class Person
	{
		public int PersonID { get; set; } = 0;

		public string FirstName { get; set; } = "";

		public string LastName { get; set; } = "";

		public int Age { get; set; } = 0;

		public DateTime BirthDay { get; set; } = DateTime.MinValue;
	}
}
