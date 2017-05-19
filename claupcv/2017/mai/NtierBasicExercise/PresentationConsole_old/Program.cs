using System;

namespace PresentationConsole
{
    class Program
    {
		static void Main(string[] args)
		{
			PersonUi personUI = new PersonUi();

			personUI.SQLFindPersonByName("clau");

			Console.WriteLine("Press anny key to end.....");
			Console.ReadKey();
		}
	}
}