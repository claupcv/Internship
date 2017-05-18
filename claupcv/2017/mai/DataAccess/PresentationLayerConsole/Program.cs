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

			// get from SQL database
			PersonDisplaysToConsole.SQLFindPersonByName("clau");

			// get from XML
			PersonDisplaysToConsole.XMLFindPersonByName("clau");
			

			Console.WriteLine("Press anny key to end.....");
			Console.ReadKey();
		}
	}
}
