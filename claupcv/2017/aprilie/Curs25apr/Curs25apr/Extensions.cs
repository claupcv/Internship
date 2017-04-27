using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs25apr
{
	public static class Extensions
	{
		public static ConditionalCustomCollection<T> ApplyCondition<T>(this IEnumerable<T> source, Icondition<T> condition)
		{
			return new ConditionalCustomCollection<T>(source, condition);
		}
	}
}
