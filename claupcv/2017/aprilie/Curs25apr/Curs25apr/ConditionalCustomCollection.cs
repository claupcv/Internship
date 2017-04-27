using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs25apr
{
	public class ConditionalCustomCollection<T> : IEnumerable<T>
	{

		private readonly ICondition<T> filter;
		private readonly IEnumerable<T> source;

		public ConditionalCustomCollection(IEnumerable<T> source, ICondition<T> condition)
		{
			if (source == null)
			{
				source = Enumerable.Empty<T>();
			}
			this.source = source;
			this.filter = condition;
		}
		public IEnumerator<T> GetEnumerator()
		{
			return GetEnumerator_Generic_UsingForeach();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator_Generic_UsingForeach();
		}

		private IEnumerator<T> GetEnumerator_Generic_UsingForeach()
		{
			foreach (var item in this.source)
			{
				var satisfiesCondition = (this.filter != null) ? this.filter.SatisfiesCondition(item) : true;
				if(satisfiesCondition)
				{
					yield return item;
				}
			}
		}
	}
}
