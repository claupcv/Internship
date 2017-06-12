using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DataAccess.Repository;
using PresentationWeb.Models;
using BusinessObject;
using Models.CRUD;

namespace PresentationWeb.Controllers
{
	public class EditPersonController : Controller
	{
		private readonly IPersonRepository personRepository;

		public EditPersonController(IPersonRepository personRepo)
		{
			this.personRepository = personRepo;
		}

		public IActionResult Index(int PersonID)
		{
			var personBO = new PersonBusinessObject(this.personRepository);
			var person = personBO.GetPersonBusiness(PersonID);
			var editPerson = new EditPerson
			{
				PersonID = person.PersonID,
				FirstName = person.FirstName,
				LastName = person.LastName,
				DateOfBirth = person.DateOfBirth
			};
			return View("Index", editPerson);
		}

		public IActionResult EditPerson(EditPerson person)
		{

			var personBO = new PersonBusinessObject(this.personRepository);

			personBO.EditPerson(new EditPersonDTO()
			{
				PersonID = person.PersonID,
				FirstName = person.FirstName,
				LastName = person.LastName,
				DateOfBirth = person.DateOfBirth
			});


			return RedirectToAction("Index", "Home");
		}
	}
}