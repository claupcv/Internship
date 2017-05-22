using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Sorting
{
	public class SortedCollection<T, TSort>
	{
		public TSort SortCriteria { get; private set; }

		public SortDirection SortDirection { get; private set; }

		public IEnumerable<T> Data { get; private set; }

		public SortedCollection(IEnumerable<T> data, TSort sortCriteria, SortDirection sortDirection)
		{
			if (data == null)
			{
				data = Enumerable.Empty<T>();
			}

			this.Data = data;

			this.SortCriteria = sortCriteria;

			this.SortDirection = sortDirection;
		}
	}
}
