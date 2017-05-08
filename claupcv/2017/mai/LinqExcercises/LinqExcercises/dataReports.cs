using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExcercises
{
	/// <summary>
	/// List of reports 
	/// </summary>
	public static class DataReports
	{
		public static IEnumerable<Person> ListOfBornPersonsByRange(Person[] persons, DateTime startDate, DateTime endDate)
		{

			if (persons == null || persons.Count() <= 0)
			{
				Console.WriteLine("NullOrEmptyPersons");
				return null;
			}
			// Check if startdate is bigger than end date.
			// If YES then reverse startDate with endDate (maybe they put wrong the date
			if (startDate > endDate)
			{
				DateTime tempDate = startDate;
				startDate = endDate;
				endDate = tempDate;
			}

			Console.WriteLine($"Persons born between {startDate.ToString("dd/MM/yyyy")} - {endDate.ToString("dd/MM/yyyy")} ");
			var bornPersonsByRange = persons
				.Where(pers => (pers.BirthDay >= startDate)
						&& (pers.BirthDay <= endDate));
			return bornPersonsByRange;
		}

		public static IEnumerable<Student> ListOfAllStudents(Person[] persons)
		{
			if (persons == null || persons.Count() <= 0)
			{
				Console.WriteLine("NullOrEmptyStudents");
				return null;
			}

			Console.WriteLine($"[List of all students]");
			var allStudents = persons.OfType<Student>()
				.Where(pers => (pers.UniversityID != null));
			return allStudents;
		}

		public static IEnumerable<Person> ListOfAllNonStudents(Person[] persons)
		{
			if (persons == null || persons.Count() <= 0)
			{
				Console.WriteLine("NullOrEmptyPersons");
				return null;
			}

			Console.WriteLine($"[List of all persons that are not students]");
			var allNonStudents = persons.
				Except(persons.OfType<Student>());
				
			return allNonStudents;
		}

		public static IEnumerable<Course> ListOfAllDistinctCourses(Course[] courses)
		{
			if (courses == null || courses.Count() <= 0)
			{
				Console.WriteLine("NullOrEmptyCourses");
				return null;
			}

			Console.WriteLine($"[List of all distinct courses]");
			var allDistinctCourse = courses.Distinct();				

			return allDistinctCourse;
		}

		public static IEnumerable<University> ListOfAllStudentsFromAllUniversities(University[] universities, Student[] students)
		{
			if (universities == null || universities.Count() <= 0)
			{
				Console.WriteLine("NullOrEmptyUniversities");
				return null;
			}

			if (students == null || students.Count() <= 0)
			{
				Console.WriteLine("NullOrEmptyStudents");
				return null;
			}

			Console.WriteLine($"[List of all students from all univerisities]");
			var allUniversitiesWithAllStudents = universities.Join(
				students,
				univ => univ.UniversityID,


				stud => stud.UniversityIDs.SelectMany(u => ),


				(university, student) => new
				{
					UniversityIDs = university.UniversityID,
					UniversityName = university.UniversityName,
					StudentName = student,
					
				}).ToArray();

			return allUniversitiesWithAllStudents.Cast<University>();
		}
	}
}
