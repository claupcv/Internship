using System;

namespace Models
{
	public class Person
	{
		public int PersonID { get; set; } = 0;

		public string FirstName { get; set; } = "";

		public string LastName { get; set; } = "";

		public DateTime DateOfBirth { get; set; } = DateTime.MinValue;
	}
}
