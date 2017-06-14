using System;
using System.ComponentModel.DataAnnotations;

namespace PresentationWeb.Models
{
	public class CreatePerson
    {
		[Required(ErrorMessageResourceName = "CreatePerson_FirstName",
			ErrorMessageResourceType = typeof(Resource))]
		[Display(Name = "FirstName")]
		public string FirstName { get; set; } = "";

		[Required(ErrorMessageResourceName = "CreatePerson_LastName",
			ErrorMessageResourceType = typeof(Resource))]
		[Display(Name = "LastName")]
		public string LastName { get; set; } = "";

		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
		[Display(Name = "DateOfBirth")]
		[Required(ErrorMessageResourceName = "CreatePerson_DateOfBirth",
			ErrorMessageResourceType = typeof(Resource))]
		public DateTime DateOfBirth { get; set; } = DateTime.MinValue;
	}
}
