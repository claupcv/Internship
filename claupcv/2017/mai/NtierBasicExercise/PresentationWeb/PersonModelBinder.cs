using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using System;
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

			var firstNameProviderResult =
				 bindingContext.ValueProvider.GetValue("txtFirstName");

			var lastNameProviderResult =
				 bindingContext.ValueProvider.GetValue("txtLastName");

			var dateOfBirthProviderResult =
				 bindingContext.ValueProvider.GetValue("txtDateOfBirth");

			DateTime dateOfBirth = DateTime.MinValue;
			DateTime.TryParse(dateOfBirthProviderResult.FirstValue, out dateOfBirth);

			bindingContext.Result = ModelBindingResult.Success(
			  new Person()
			  {
				  FirstName = firstNameProviderResult.FirstValue,
				  LastName = lastNameProviderResult.FirstValue,
				  DateOfBirth = dateOfBirth
			  });

			return TaskCache.CompletedTask;
		}
	}
}
