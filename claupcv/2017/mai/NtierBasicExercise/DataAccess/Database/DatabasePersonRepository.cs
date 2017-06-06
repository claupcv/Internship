using Models;
using Models.Sorting;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccess.Database
{
	public class DatabasePersonRepository : IPersonRepository
	{
		private readonly string connectionString;

		public DatabasePersonRepository(GlobalSettings settings)
			 : this(connectionString: settings?.RepositoriesConfig?.Database?.ConnectionString)
		{

		}

		protected DatabasePersonRepository(string connectionString)
		{
			if (string.IsNullOrWhiteSpace(connectionString))
			{
				throw new ArgumentNullException(nameof(connectionString));
			}

			this.connectionString = connectionString;
		}
		public SortedCollection<Person, PersonSortCriteria> GetPersonSorted(PersonSortCriteria sortCriteria, SortDirection sortDirection)
		{
			var sqlSort = new StringBuilder();
			sqlSort.Append("LastName ASC");
			var sqlData = new StringBuilder();
			sqlData.Append(@"
				SELECT [PersonID]
				  ,[FirstName]
				  ,[LastName]
				  ,[DateOfBirth]
				FROM [dbo].[persons] order by " + sqlSort.ToString());

			List<Person> itemsPerPage = new List<Person>();

			using (var sqlConnection = new SqlConnection(this.connectionString))
			{
				sqlConnection.Open();

				using (var sqlCmd = new SqlCommand(sqlData.ToString(), sqlConnection))
				{
					using (var reader = sqlCmd.ExecuteReader())
					{
						while (reader.Read())
						{
							itemsPerPage.Add(new Person
							{
								PersonID = (int)reader["PersonID"],
								FirstName = reader["FirstName"]?.ToString(),
								LastName = reader["LastName"]?.ToString(),
								DateOfBirth = (reader["DateOfBirth"] != DBNull.Value) ? (DateTime)reader["DateOfBirth"] : DateTime.MinValue
							});
						}
					}
				}
				sqlConnection.Close();
			}

			return new SortedCollection<Person, PersonSortCriteria>(itemsPerPage, sortCriteria, sortDirection);
		}
	}
}
