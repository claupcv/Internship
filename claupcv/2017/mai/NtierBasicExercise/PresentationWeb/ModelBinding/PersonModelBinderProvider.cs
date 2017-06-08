using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;

namespace PresentationWeb
{
	public class PersonModelBinderProvider : IModelBinderProvider
	{
		public IModelBinder GetBinder(ModelBinderProviderContext context)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}

			if (context.Metadata.ModelType == typeof(Person))
			{
				return new BinderTypeModelBinder(typeof(PersonModelBinder));
			}

			return null;
		}
	}
}
