using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DataAccess.Repository;
using BusinessObject;
using PresentationWeb.Models;
using Models;

namespace PresentationWeb.Controllers
{
    public class DeletePersonController : Controller
    {
		private readonly IPersonRepository personRepository;

		public DeletePersonController(IPersonRepository personRepo)
		{
			this.personRepository = personRepo;
		}

		public IActionResult Index(int PersonID)
		{
			var personBO = new PersonBusinessObject(this.personRepository);
			var person = personBO.GetPersonBusiness(PersonID);

			return View("Index", person);
		}

		public IActionResult DeletePerson(Person person)
		{
			var personBO = new PersonBusinessObject(this.personRepository);
			personBO.DeletePersonBusiness(person);
			return RedirectToAction("Index", "Home");
		}
	}
}