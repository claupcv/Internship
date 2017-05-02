using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curs27apr
{
	public delegate int Sum(int a, int b);

	public delegate void RadioBrodcast(string message);
	public class DelegateDefinitions
	{
		private int IntCalculator(int a, int b)
		{
			return a + b;
		}
	}
}
