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
using System.Data;

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

		public Person Add(Person person)
		{

			using (var sqlConnection = new SqlConnection(this.connectionString))
			{
				using (SqlCommand command = new SqlCommand())
				{

					command.Connection = sqlConnection;            // <== lacking
					command.CommandType = CommandType.Text;
					command.CommandText = $"INSERT INTO Persons(FirstName,LastName,DateOfBirth) VALUES (@FirstName,@LastName, @DateOfBirth) ";
					command.Parameters.AddWithValue("@FirstName", person.FirstName);
					command.Parameters.AddWithValue("@LastName", person.LastName);
					command.Parameters.AddWithValue("@DateOfBirth", person.DateOfBirth);

					try
					{
						sqlConnection.Open();
						int recordsAffected = command.ExecuteNonQuery();
					}
					catch (SqlException)
					{
						return new Person();
					}
					finally
					{
						sqlConnection.Close();
					}
				}
			}

			return new Person();
		}

		public Person Delete(Person person)
		{
			using (var sqlConnection = new SqlConnection(this.connectionString))
			{
				using (SqlCommand command = new SqlCommand())
				{

					command.Connection = sqlConnection;            // <== lacking
					command.CommandType = CommandType.Text;
					command.CommandText = $"DELETE FROM [dbo].[Persons] WHERE PersonID= @personID";
					command.Parameters.AddWithValue("@personID", person.PersonID);

					try
					{
						sqlConnection.Open();
						int recordsAffected = command.ExecuteNonQuery();
					}
					catch (SqlException)
					{
						return new Person();
					}
					finally
					{
						sqlConnection.Close();
					}
				}
			}

			return new Person();
		}

		public Person Edit(Person person)
		{
			using (var sqlConnection = new SqlConnection(this.connectionString))
			{
				using (SqlCommand command = new SqlCommand())
				{

					var formatDateOfBrth = $"{person.DateOfBirth.Year.ToString()}-" +
						$"{person.DateOfBirth.Month.ToString()}-{person.DateOfBirth.Day.ToString()}";

					command.Connection = sqlConnection;            // <== lacking
					command.CommandType = CommandType.Text;
					command.CommandText = $"UPDATE Persons   SET FirstName = @FirstName,LastName = @lastName, DateOfBirth = @dateOfBirth WHERE PersonID=@personID";
					command.Parameters.AddWithValue("@personID", person.PersonID);
					command.Parameters.AddWithValue("@firstName", person.FirstName);
					command.Parameters.AddWithValue("@lastName", person.LastName);
					command.Parameters.AddWithValue("@dateOfBirth", formatDateOfBrth);

					try
					{
						sqlConnection.Open();
						int recordsAffected = command.ExecuteNonQuery();
					}
					catch (SqlException)
					{
						return new Person();
					}
					finally
					{
						sqlConnection.Close();
					}
				}
			}
			return new Person();

		}

		public Person GetPerson(int PersonID)
		{

			Person person = new Person();

			using (var sqlConnection = new SqlConnection(this.connectionString))
			{
				using (SqlCommand command = new SqlCommand())
				{

					command.Connection = sqlConnection;
					command.CommandType = CommandType.Text;
					command.CommandText = $"SELECT Top 1 * FROM persons WHERE PersonID=@personID";
					command.Parameters.AddWithValue("@personID", PersonID);

					sqlConnection.Open();
					using (var reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							person = new Person()
							{
								PersonID = (int)reader["PersonID"],
								FirstName = reader["FirstName"]?.ToString(),
								LastName = reader["LastName"]?.ToString(),
								DateOfBirth = (reader["DateOfBirth"] != DBNull.Value) ? (DateTime)reader["DateOfBirth"] : DateTime.MinValue
							};
						}
					}


				}
			}
			return person;
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
