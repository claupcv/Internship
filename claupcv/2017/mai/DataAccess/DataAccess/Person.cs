using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
	[Table("Persons")] // Table name
	public class Person
	{
		public int PersonID { get; set; } = 0;

		public string FirstName { get; set; } = "";

		public string LastName { get; set; } = "";

		public DateTime DateOfBirth { get; set; } = DateTime.MinValue;
	}
}
