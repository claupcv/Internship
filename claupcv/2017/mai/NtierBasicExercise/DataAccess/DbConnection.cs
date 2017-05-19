using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;

namespace DataAccess
{
	public class DbConnection
	{
		private SqlDataAdapter myAdapter;

		private SqlConnection conn;

		ConnectionStringSettings connectionString = ConfigurationManager.ConnectionStrings["AppConnectionString"];

		public DbConnection()
		{
			
			if (this.connectionString != null)
			{
				this.myAdapter = new SqlDataAdapter();
				this.conn = new SqlConnection(this.connectionString.ToString());
				this.conn.Open();
			}
			else
			{
				throw new Exception("NullConectionString");
			}
		}

		private SqlConnection openConnection()
		{
			if (conn.State == ConnectionState.Closed || conn.State ==
						ConnectionState.Broken)
			{
				conn.Open();
			}
			return conn;
		}
	}
}
