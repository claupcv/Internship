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


			ViewBag.IDSortParam = String.IsNullOrEmpty(sortOrder) ? "id_desc" : "";

			ViewBag.FirstNameSortParam = sortOrder == "firstName" ? "firstName_desc" : "firstName";

			ViewBag.birthtDateSortParam = sortOrder == "birthtDate" ? "birthtDate_desc" : "birthtDate";



			if (sortOrder == "Desc")
			{
				sortDirection = SortDirection.Descending;
			}

			if (sortParam == "id" && sortOrder == "Asc")

				ViewBag.paramCriteria = sortParam;


			switch (sortOrder)
			{
				case "id_desc":
					SortCriteria = PersonSortCriteria.ById;
					sortDirection = SortDirection.Descending;
					break;
				case "firstName":
					SortCriteria = PersonSortCriteria.ByFirstName;
					sortDirection = SortDirection.Ascending;
					break;
				case "firstName_desc":
					SortCriteria = PersonSortCriteria.ByFirstName;
					sortDirection = SortDirection.Descending;
					break;
				case "birthtDate":
					SortCriteria = PersonSortCriteria.ByBirthDate;
					sortDirection = SortDirection.Ascending;
					break;
				case "birthtDate_desc":
					SortCriteria = PersonSortCriteria.ByBirthDate;
					sortDirection = SortDirection.Descending;
					break;
				default:
					SortCriteria = PersonSortCriteria.ById;
					sortDirection = SortDirection.Ascending;
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

		public IActionResult DeletePerson(Person person)
		{
			var personBO = new PersonBusinessObject(this.personRepository);

			ViewBag.InsertResult = personBO.DeletePerson(person).ToString();

			return RedirectToAction("Index");
		}

		public IActionResult EditPerson(Person person)
		{
			return View(person);
		}

		public IActionResult PostEditPerson(Person person)
		{
			var personBO = new PersonBusinessObject(this.personRepository);

			ViewBag.InsertResult = personBO.EditPerson(person).ToString();

			return RedirectToAction("Index");
		}
	}
}
