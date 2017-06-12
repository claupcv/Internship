using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using Models;
using Microsoft.AspNetCore.Mvc.Internal;

namespace PresentationWeb
{
	public class PersonModelBinder : IModelBinder
	{
		public Task BindModelAsync(ModelBindingContext bindingContext)
		{
			if (bindingContext == null)
			{
				throw new ArgumentNullException(nameof(bindingContext));
			}

			var personIDProviderResult =
				 bindingContext.ValueProvider.GetValue("PersonID");

			var firstNameProviderResult =
				 bindingContext.ValueProvider.GetValue("FirstName");

			var lastNameProviderResult =
				 bindingContext.ValueProvider.GetValue("LastName");

			var dateOfBirthProviderResult =
				 bindingContext.ValueProvider.GetValue("DateOfBirth");

			DateTime dateOfBirth = DateTime.MinValue;
			DateTime.TryParse(dateOfBirthProviderResult.FirstValue, out dateOfBirth);

			bindingContext.Result = ModelBindingResult.Success(
			  new Person()
			  {
				  PersonID = int.Parse(personIDProviderResult.FirstValue),
				  FirstName = firstNameProviderResult.FirstValue,
				  LastName = lastNameProviderResult.FirstValue,
				  DateOfBirth = dateOfBirth
			  });

			return TaskCache.CompletedTask;
		}
	}
}
