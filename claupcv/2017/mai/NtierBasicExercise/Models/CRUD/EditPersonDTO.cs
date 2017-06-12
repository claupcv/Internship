using System;
using System.Collections.Generic;
using System.Text;

namespace Models.CRUD
{
    public class EditPersonDTO
    {
		public int PersonID { get; set; } = -1;

		public string FirstName { get; set; } = "";

		public string LastName { get; set; } = "";

		public DateTime DateOfBirth { get; set; } = DateTime.MinValue;
	}
}
