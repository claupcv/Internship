using Models;
using Models.Sorting;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Models.Core;

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
			ValueTypeMultiSwitch<PersonSortCriteria, SortDirection>
			  .On(sortCriteria, sortDirection)
			  .Case(PersonSortCriteria.ById, SortDirection.Ascending, () => sqlSort.Append("PersonID Asc"))
			  .Case(PersonSortCriteria.ById, SortDirection.Descending, () => sqlSort.Append("PersonID Desc"))
			  .Case(PersonSortCriteria.ByFirstName, SortDirection.Ascending, () => sqlSort.Append("FirstName Asc"))
			  .Case(PersonSortCriteria.ByFirstName, SortDirection.Descending, () => sqlSort.Append("FirstName Desc"))
			  .Case(PersonSortCriteria.ByLastName, SortDirection.Ascending, () => sqlSort.Append("LastName Asc"))
			  .Case(PersonSortCriteria.ByLastName, SortDirection.Descending, () => sqlSort.Append("LastName Desc"))
			  .Case(PersonSortCriteria.ByBirthDate, SortDirection.Ascending, () => sqlSort.Append("DateOfBirth Asc"))
			  .Case(PersonSortCriteria.ByBirthDate, SortDirection.Descending, () => sqlSort.Append("DateOfBirth Desc"))
			  .Default(() => sqlSort.Append("PersonID Asc"))
			  .Evaluate();


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
