using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExcercises
{
	class Program
	{
		static void Main(string[] args)
		{
			var persons = ElementsCreator.CreatePersonsAndStudents();
			var students = DataReports.ListOfAllStudents(persons).ToArray();
			var courses = ElementsCreator.CreateCourses();
			var universities = ElementsCreator.CreateUniversities();
			var attendedUniversity = ElementsCreator.CreateAtendedUniversites();


			DateTime startDate = new DateTime(1986, 2, 10);
			DateTime endDate = new DateTime(1987, 12, 15);


			var personsRange = DataReports.ListOfBornPersonsByRange(persons, startDate, endDate);
			ConsoleManagement.ForeachShowPersonsToConsole(personsRange);


			var allStudents = students;
			ConsoleManagement.ForeachShowStudentsToConsole(allStudents);

			
			var allNonStudents = DataReports.ListOfAllNonStudents(persons);
			ConsoleManagement.ForeachShowPersonsToConsole(allNonStudents);


			var allDistinctCourse = DataReports.ListOfAllDistinctCourses(courses);
			ConsoleManagement.ForeachShowCoursesToConsole(allDistinctCourse);


			var allUniversitiesWithAllStudents = DataReports.ListOfAllStudentsFromAllUniversities(universities, attendedUniversity, students);
			//nu este nevoie din cauza tipului care nus tiu cum sa il iau
			//ConsoleManagement.ForeachShowAllStudentsToAllUniverisites(allUniversitiesWithAllStudents);





			Console.Read();
		}
	}
}
