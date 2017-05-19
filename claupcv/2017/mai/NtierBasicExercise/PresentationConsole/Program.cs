using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			personUI personUI = new PersonUi();

			personUI.SQLFindPersonByName("clau");

			Console.WriteLine("Press anny key to end.....");
			Console.ReadKey();
		}
	}
}
