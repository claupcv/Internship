using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models;
using BusinessObject;
using DataAccess.Repository;
using PresentationWeb.Models;
using Models.CRUD;

namespace PresentationWeb.Controllers
{
    public class AddPersonController : Controller
    {

		private readonly IPersonRepository personRepository;

		public AddPersonController(IPersonRepository personRepo)
		{
			this.personRepository = personRepo;
		}

		public IActionResult Index()
        {
            return View();
        }

		public IActionResult Save(CreatePerson person)
		{
			var personBO = new PersonBusinessObject(this.personRepository);

			personBO.AddPerson(new CreatePersonDTO()
			{
				FirstName = person.FirstName,
				LastName = person.LastName,
				DateOfBirth = person.DateOfBirth
			});


			return RedirectToAction("AddPerson");
		}
	}
}