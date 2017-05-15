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

			if (persons == null || persons.Length <= 0)
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
			if (persons == null || persons.Length <= 0)
			{
				Console.WriteLine("NullOrEmptyStudents");
				return null;
			}

			Console.WriteLine($"[List of all students]");
			var allStudents = persons.OfType<Student>()
				.Where(pers => (pers.AtendedUniversityIDs != null));
			return allStudents;
		}

		public static IEnumerable<Person> ListOfAllNonStudents(Person[] persons)
		{
			if (persons == null || persons.Length <= 0)
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
			if (courses == null || courses.Length <= 0)
			{
				Console.WriteLine("NullOrEmptyCourses");
				return null;
			}

			Console.WriteLine($"[List of all distinct courses]");
			var allDistinctCourse = courses.Distinct();

			return allDistinctCourse;
		}

		//public static IEnumerable<Tuple<string, string>> ListOfAllStudentsFromAllUniversities
		public static bool? ListOfAllStudentsFromAllUniversities
			(University[] universities, AttendedUniversity[] attendedUniversities, Student[] students)
		{
			if (universities == null || universities.Length <= 0)
			{
				Console.WriteLine("NullOrEmptyUniversities");
				return null;
			}

			if (attendedUniversities == null || attendedUniversities.Length <= 0)
			{
				Console.WriteLine("NullOrEmptyAtendedUniversities");
				return null;
			}

			if (students == null || students.Length <= 0)
			{
				Console.WriteLine("NullOrEmptyStudents");
				return null;
			}

			Console.WriteLine($"[List of all students from all univerisities]");

			var allUniversitiesWithAllStudents = universities.Join(

				attendedUniversities.Join(
					students.SelectMany(
						student => student.AtendedUniversityIDs,
						(student, UniversityID) => new
						{ student.PersonID, student.FirstName, student.LastName, UniversityID }),
					attendedUniv => attendedUniv.AttendedUniversityID,
					stud => stud.UniversityID,
					(attendedUniv, student) => new
					{
						UniversityID = attendedUniv.UniversityID,
						StudentExtended = student,
					}),
				univ => univ.UniversityID,
				attendedUniv => attendedUniv.UniversityID,
				(attendedUniv, student) => new
				{
					UniversityName = attendedUniv.UniversityName,
					StudentExtended = student,


				})
				.Select(attendedUniv => new Tuple<string, string>(
						attendedUniv.UniversityName,
						string.Join(", ", attendedUniv.StudentExtended.StudentExtended
							//.Select(stud => $"{stud.FirstName} {stud.LastName}")
							)))

				.ToList();

			foreach (var univ in allUniversitiesWithAllStudents)
			{
				Console.WriteLine($"Univeristy = {univ} has following students :" +
					$"{univ.Item1} {univ.Item2}");
			}

			//foreach (var univ in allUniversitiesWithAllStudents)
			//{
			//	var Students = string.Join(", ", univ.StudentExtended.Select(stud => $"{stud.FirstName} {stud.LastName}"));

			//	if (Students.Length > 0)
			//	{
			//		Console.WriteLine($"Univeristy = {univ.UniversityName} has following students :{Students}");
			//	}

			//}


			return true;
		}

		public static List<Course> ReturnLongestCourseName(Course[] course)
		{

			if (course == null || course.Length <= 0)
			{
				Console.WriteLine("NullOrEmptyCourses");
				return null;
			}

			var query = course.GroupBy(e => e.CourseName.Length)
						.FirstOrDefault().ToList();
			return query;
		}

		public static IEnumerable<String> AllCoursesFromUniversityForAYear(Course[] courses, University[] universities,  int universityID, int year)
		{
			var query = from course in courses
						join university in universities on course.UniversityID equals university.UniversityID
						where university.UniversityID == universityID
						where course.CourseYear == year
						select course.CourseName;
			return query;
		}

		public static IEnumerable<String> GetAllStudentsFromUniveristyByPage(Student[] students, AttendedUniversity[] attendedUniversities, University[] universities, int pageIndex, int universityID, int pageSize)
		{

			var query = from student in students
						from attendedUniversitie in attendedUniversities
						select new
						{
							Student = student,
							UniversityID = attendedUniversitie.UniversityID
						} into studUniv
						join university in universities
						on studUniv.UniversityID equals university.UniversityID
						where university.UniversityID == universityID
						select studUniv.Student;

			int totalNomberOfStudent = query.Count();

			var pageStudent = query.Skip((pageIndex+1) * pageSize);

			
			return pageStudent;
		}


	}
}
