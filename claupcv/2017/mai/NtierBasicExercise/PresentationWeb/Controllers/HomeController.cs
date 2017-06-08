using BusinessObject;
using DataAccess.Repository;
using Microsoft.AspNetCore.Mvc;
using Models;
using Models.Extensions;
using Models.Sorting;
using System;

namespace PresentationWeb.Controllers
{
	public class HomeController : Controller
	{
		private readonly IPersonRepository personRepository;

		public HomeController(IPersonRepository personRepository)
		{
			if (personRepository == null)
			{
				throw new ArgumentNullException($"{nameof(personRepository)}");
			}

			this.personRepository = personRepository;
		}



		public IActionResult Index(string sortParam, string sortOrder)
		{
			var SortCriteria = PersonSortCriteria.ById;

			var sortDirection = SortDirection.Ascending;

			if (sortOrder == "Desc")
			{
				sortDirection = SortDirection.Descending;
			}

			if (sortParam == "id" && sortOrder == "Asc")

				ViewBag.paramCriteria = sortParam;


			switch (sortParam)
			{
				case "id":
					SortCriteria = PersonSortCriteria.ById;
					break;
				case "firstName":
					SortCriteria = PersonSortCriteria.ByFirstName;
					break;
				case "birthtDate":
					SortCriteria = PersonSortCriteria.ByBirthDate;
					break;
				default:
					SortCriteria = PersonSortCriteria.ById;
					break;
			}

			return this.List(criteria: SortCriteria, sortDirection: sortDirection);
		}


		public IActionResult List(int pageIndex = 0, int pageSize = 20, PersonSortCriteria criteria = PersonSortCriteria.ById, SortDirection sortDirection = SortDirection.Ascending)
		{
			var personBO = new PersonBusinessObject(this.personRepository);

			var data = personBO.GetPersonsPaged(criteria, sortDirection);

			return View("Index", data);
		}

		public IActionResult Error()
		{
			return View();
		}

		public IActionResult AddPerson()
		{
			return View();
		}

		public IActionResult PostAddPerson(string FirstName, string LastName, string DateOfBirth)
		{
			//Redirect("AddPerson");
			return Redirect("AddPerson");
		}
	}
}
