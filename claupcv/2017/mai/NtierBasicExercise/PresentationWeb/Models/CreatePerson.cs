﻿using System;
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

		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
		[Required(ErrorMessageResourceName = "CreatePerson_DateOfBirth",
			ErrorMessageResourceType = typeof(Resource))]
		public DateTime DateOfBirth { get; set; } = DateTime.MinValue;
	}
}
