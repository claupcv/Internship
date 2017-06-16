using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DataAccess.Repository;
using PresentationWeb.Models;
using BusinessObject;
using Models.CRUD;
using Microsoft.AspNetCore.Mvc.Localization;
using System.Globalization;

namespace PresentationWeb.Controllers
{
	public class EditPersonController : Controller
	{
		private readonly IPersonRepository personRepository;

		IViewLocalizer Localizer;

		public string GetRequestDateFormat(bool formatJS = true)
		{
			var reqLang = this.Request.Headers["Accept-Language"].ToString();
			if (reqLang.StartsWith("ro,") ||
				reqLang.StartsWith("ro-") ||
				reqLang.StartsWith("ro;"))
			{
				if (formatJS == true)
				{
					return "dd.mm.yy";
				}
				else
				{
					return "dd.MM.yyyy";
				}

			}
			if (formatJS == true)
			{
				return "mm/dd/yy";
			}
			else
			{
				return "MM/dd/yyyy";
			}
		}

		public EditPersonController(IPersonRepository personRepo)
		{
			this.personRepository = personRepo;
		}

		public IActionResult Index(int PersonID)
		{
			var reqLang = this.Request.Headers["Accept-Language"].ToString();
			if (reqLang.StartsWith("ro,") ||
				reqLang.StartsWith("ro-") ||
				reqLang.StartsWith("ro;"))
			{
				CultureInfo.CurrentCulture = new CultureInfo("ro");
				CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd.MM.yyyy";
			}
			else
			{
				CultureInfo.CurrentCulture = new CultureInfo("en");
				CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy";
			}

			var personBO = new PersonBusinessObject(this.personRepository);
			var person = personBO.GetPersonBusiness(PersonID);
			var temp = System.Convert.ToDateTime(person.DateOfBirth.ToString()).ToString($"{GetRequestDateFormat(false)} ");
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