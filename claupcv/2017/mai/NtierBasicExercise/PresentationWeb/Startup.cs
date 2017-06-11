﻿using DataAccess.Repository;
using DataAccess.Database;
using DataAccess.InMemory;
using DataAccess.XML;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Models;
using Models.Core;
using Models.IO;
using Microsoft.AspNetCore.Mvc.Razor;
using System.Globalization;
using Microsoft.AspNetCore.Localization;

namespace PresentationWeb
{
	public class Startup
	{
		public Startup(IHostingEnvironment env)
		{
			var builder = new ConfigurationBuilder()
				.SetBasePath(env.ContentRootPath)
				.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
				.AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
				.AddEnvironmentVariables();

			Configuration = builder.Build();
		}

		public IConfigurationRoot Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddOptions()
					.Configure<GlobalSettings>(Configuration.GetSection("Configuration"));
			services.AddLocalization(options => options.ResourcesPath = "Resources");
			// Add framework services.
			services.AddMvc(
				options =>
				{
					options.ModelBinderProviders.Insert(0, new PersonModelBinderProvider());

				})
				.AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
				.AddDataAnnotationsLocalization();

			services
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
			 });
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
		{

			var supportedCultures = new[]
			{
				new CultureInfo("en-US"),
				new CultureInfo("ro-RO"),
			};

			app.UseRequestLocalization(new RequestLocalizationOptions
			{
				DefaultRequestCulture = new RequestCulture("en-US"),
				// Formatting numbers, dates, etc.
				SupportedCultures = supportedCultures,
				// UI strings that we have localized.
				SupportedUICultures = supportedCultures
			});

			loggerFactory.AddConsole(Configuration.GetSection("Logging"));
			loggerFactory.AddDebug();

			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
				app.UseBrowserLink();
			}
			else
			{
				app.UseExceptionHandler("/Home/Error");
			}

			app.UseStaticFiles();

			app.UseMvc(routes =>
			{
				routes.MapRoute(
						  name: "default",
						  template: "{controller=Home}/{action=Index}/{id?}");
			});
		}
	}
}
