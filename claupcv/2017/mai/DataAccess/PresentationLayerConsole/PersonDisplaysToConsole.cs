using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace PresentationLayerConsole
{
	public static class PersonDisplaysToConsole
	{
		public static void SQLFindPersonByName(string text)
		{
			PersonBusinessObject pers = new PersonBusinessObject();
			pers.GetPersonByName(text);
		}

		public static void XMLFindPersonByName(string text)
		{
			PersonBusinessObject pers = new PersonBusinessObject();
			pers.GetPersonByName(text);
		}

	}
}
