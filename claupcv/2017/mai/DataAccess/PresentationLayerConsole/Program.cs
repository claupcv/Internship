using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BusinessObject;

namespace PresentationLayerConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			PersonBusinessObject pers = new PersonBusinessObject();
			pers.GetPersonByName("clau");
		}
	}
}
