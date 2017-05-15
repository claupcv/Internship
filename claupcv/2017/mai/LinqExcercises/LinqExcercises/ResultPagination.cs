using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExcercises
{
	public partial class ResultPagination
	{
		public class PageCollection<T>
		{

			public PageCollection(
				IEnumerable<T> itemsPerPage,
				int pagesize,
				int pageIndex,
				int totalElementsCount)
			{
				if (itemsPerPage == null)
				{
					itemsPerPage = Enumerable.Empty<T>();
				}
			}


			public IEnumerable <T> items { get; private set; }

			public int PageSize { get; private set; }

			public int PageIndex { get; private set; }

			public int TotalElementsCount { get; private set; }

		}
	}
}
