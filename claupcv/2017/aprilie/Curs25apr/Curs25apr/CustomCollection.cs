using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs25apr
{
	public class CustomCollection<T> : IEnumerable<T>
	{
		private readonly List<T> backingList;

		private int counter;

		public CustomCollection(params T[] elements)
			:this(enumeration:elements)
		{

		}

		public CustomCollection(IEnumerable<T> enumeration)
		{
			if (enumeration == null)
			{
				enumeration = Enumerable.Empty<T>();
			}

			this.backingList = new List<T>();

			this.backingList.AddRange(enumeration);
		}

		public IEnumerator<T> GetEnumerator()
		{
			DebugTool.DebugMesg("Debuged");
			Console.WriteLine("GetEnumerator_UsingForeach_generic");
			return this.GetEnumerator_UsingForeach();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			DebugTool.DebugMesg("Debuged");
			Console.WriteLine("GetEnumerator_UsingForeach_nongeneric");
			return this.GetEnumerator_UsingForeach();
		}

		private IEnumerator<T> GetEnumerator_UsingForeach()
		{
			Console.WriteLine("GetEnumerator_UsingForeach");

			foreach (var item in this.backingList)
			{
				counter++;
				if (this.counter == 2)
				{
					yield break;
				}
				Console.WriteLine("New element");
				yield return item;
			}
		}

		private IEnumerator<T> GetEnumerator_UsingCustomEnumerator()
		{
			Console.WriteLine("GetEnumerator_UsingCustomEnumerator");
			return new CustomEnumator<T>(this.backingList.ToArray());
		}
	}
}
