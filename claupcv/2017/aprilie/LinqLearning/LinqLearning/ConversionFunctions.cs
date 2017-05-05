using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace LinqLearning
{
	public static class ConversionFunctions
	{
		public static void AsEnumerableMethod()
		{
			Console.WriteLine("AsEnumerableMethod");

			DataTable table = new DataTable();
			table.Columns.AddRange(
			  new DataColumn[]
			  {
				new DataColumn("Id", typeof(int)),
				new DataColumn("Desc", typeof(string))
			  });

			table.Rows.Add(1, "Desc 1");
			table.Rows.Add(2, "Desc 2");
			table.Rows.Add(3, "Desc 3");

			var result = table.AsEnumerable()
				.Where(row => (int)row["Id"] == 2)
				.Select(row => row["Desc"] as string);

			foreach (string s in result)
			{
				Console.WriteLine(s);
			}

		}

		public static void CastMethod()
		{
			Console.WriteLine("CastMethod");

			var arrayList = new ArrayList();
			arrayList.Add(1);
			arrayList.Add(2);
			arrayList.Add(3);

			//IEnumerable<int> result = arrayList.Cast<int>();

			foreach (int element in arrayList)
			{
				Console.Write(element + ", ");
			}

		}
	}
}
