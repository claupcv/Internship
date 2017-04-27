
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs25apr
{
	public class CustomEnumator<T> : IEnumerator<T>
	{
		private T[] array;
		private int startIndex;
		private int curentIndex;
		private int endIndex;

		public CustomEnumator(T[] array)
		{
			if (array==null)
			{
				this.array = array
					??
					throw new ArgumentNullException(nameof(array));
				this.startIndex = 0;
				this.curentIndex = -1;
				this.endIndex = array.Length - 1;

			}
		}

		public T Current
		{
			get
			{
				if ((this.curentIndex < this.startIndex) ||
						(this.curentIndex > this.endIndex))
				{
					throw new IndexOutOfRangeException();
				}
				return this.array[this.curentIndex];
			}
		}

		object IEnumerator.Current
		{
			get
			{
				return this.curentIndex;
			}
		}

		public void Dispose()
		{
			this.array = null;
		}

		public bool MoveNext()
		{
			if(this.array[this.curentIndex + 1] == null)
			{
				return false;
			}
			else
			{
				return true;
			}
			 
		}

		public void Reset()
		{
			this.curentIndex = -1;
		}
	}
}
