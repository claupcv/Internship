using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs25apr
{
	public interface ICondition <T>
	{
		bool SatisfiesCondition(T  element);
	}

	public class NumberIsOdd : ICondition<int>
	{
		public bool SatisfiesCondition(int element)
		{
			return element % 2 != 0;
		}
	}

	public class NumberIsEven : ICondition<int>
	{
		public bool SatisfiesCondition(int element)
		{
			return element % 2 == 0;
		}
	}

	public class NumberIsLesThan : ICondition<int>
	{
		private int referenceNumber;
		public NumberIsLesThan(int number)
		{
			this.referenceNumber = number;
		}
		public bool SatisfiedCondition(int numer)
		{
			return numer % 2 == 0;
		}
	}
}
