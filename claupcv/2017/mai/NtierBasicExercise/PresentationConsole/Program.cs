using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System.IO;
using Models;
using Models.Sorting;
using DataAccess;
using Presentation.ConsoleUI.Views.Abstractions;
using Models.IO;
using DataAccess.Repository;
using Models.Core;
using Presentation.ConsoleUI.Views.Implementation;
using DataAccess.Database;
using DataAccess.InMemory;

namespace PresentationConsole
{
	class Program
	{
		private static IConfigurationRoot CreateConfigurationRoot()
		{
			var configBuilder = new ConfigurationBuilder()
			.SetBasePath(Directory.GetCurrentDirectory())
			.AddJsonFile(path: "appSettings.json", optional: false, reloadOnChange: true);

			var configRoot = configBuilder.Build();

			return configRoot;
		}

		private static IServiceProvider CreateServiceProvider(IConfigurationRoot configRoot)
		{

			var serviceCollection = new ServiceCollection();

			serviceCollection
				.AddOptions()
				.Configure<GlobalSettings>(configRoot.GetSection("Configuration"));

			// register dependencies
			serviceCollection
			  .AddSingleton(provider => provider.GetService<IOptions<GlobalSettings>>().Value)
			  .AddTransient<IPathServices, DefaultPathServices>()
			  .AddTransient<IPersonRepository>(provider =>
			  {
				  var globalSettings = provider.GetService<IOptions<GlobalSettings>>().Value;

				  return StringSwitch<IPersonRepository>
					.On(globalSettings.UsedRepo)
					.Case("Xml", () => new XmlPersonRepository(
										settings: globalSettings,
										pathServices: provider.GetService<IPathServices>()))
					.MultiCase(new[] { "Db", "Database" }, () => new DatabasePersonRepository(globalSettings))
					.Default(() => new InMemoryPersonRepository())
					.Evaluate();
			  })
			  .AddTransient<IView<SortedCollection<Person, PersonSortCriteria>>, PersonListingView>();

			var serviceProvider = serviceCollection.BuildServiceProvider();

			return serviceProvider;
		}
		static void Main(string[] args)
		{

			var configRoot = CreateConfigurationRoot();

			var serviceProvider = CreateServiceProvider(configRoot);

			Console.WriteLine("Press anny key to end.....");
			Console.ReadKey();
		}
	}
}
