using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs25apr
{
	public static class DebugTool
	{

		[ConditionalAttribute("Debug_MSG")]
		public static void DebugMesg(string message)
		{
		#if Debug_MSG
			if (Debugger.IsAttached)
			{
				Console.WriteLine(message);
			}
		#endif

		}
	}
}
