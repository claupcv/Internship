using System;
using System.ComponentModel.DataAnnotations;

namespace PresentationWeb.Models
{
	public class CreatePerson
    {
		[Required(ErrorMessageResourceName = "CreatePerson_FirstName",
			ErrorMessageResourceType = typeof(Resource))]
		public string FirstName { get; set; } = "";

		[Required(ErrorMessageResourceName = "CreatePerson_LastName",
			ErrorMessageResourceType = typeof(Resource))]
		public string LastName { get; set; } = "";

		[Required(ErrorMessageResourceName = "CreatePerson_DateOfBirth",
			ErrorMessageResourceType = typeof(Resource))]
		public DateTime DateOfBirth { get; set; } = DateTime.MinValue;
	}
}
