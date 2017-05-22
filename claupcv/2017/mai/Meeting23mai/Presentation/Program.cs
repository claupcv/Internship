using System;
using Presentation.Views.Implementation;
using DataAccess.InMemory;
using Microsoft.Extensions.DependencyInjection;
using DataAccess.Abstractions;

namespace Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
			var serviceCollection = new ServiceCollection();

			serviceCollection
				.AddTransient<IPersonRepository, InMemoryPersonRepository>();

			var serviceProvider = serviceCollection.BuildServiceProvider();

			PersonUi ui = new PersonUi(
		pageSize: 10,
		personRepository: serviceProvider.GetService<IPersonRepository>(),
		personListingView: new PersonListingView() ,
		menuView: new MenuView(),
		unknownCommandView: new UnknownCommandView());

			ui.Start();

			Console.WriteLine("Hello World!");

			Console.ReadKey();
        }
    }
}