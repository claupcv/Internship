using System;
using System.ComponentModel.DataAnnotations;

namespace PresentationWeb.Models
{
	public class EditPerson
    {
		[Required]
		public int PersonID { get; set; }

		[Required(ErrorMessageResourceName = "EditPerson_FirstName",
			ErrorMessageResourceType = typeof(Resource))]
		public string FirstName { get; set; } = "";

		[Required(ErrorMessageResourceName = "EditPerson_LastName",
			ErrorMessageResourceType = typeof(Resource))]
		public string LastName { get; set; } = "";

		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
		[Required(ErrorMessageResourceName = "EditPerson_DateOfBirth",
			ErrorMessageResourceType = typeof(Resource))]
		public DateTime DateOfBirth { get; set; } = DateTime.MinValue;
	}
}
