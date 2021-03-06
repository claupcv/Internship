﻿using System;
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
						studentID => studentID.AtendedUniversityIDs ,
						(student, atendedUniversityID) => new
						{
							PersonID = student.PersonID,
							FirstName = student.FirstName,
							LastName = student.LastName,
							AtendedUniversityID = atendedUniversityID
						}).ToList(),

					attendedUniv => attendedUniv.AttendedUniversityID,
					stud => stud.AtendedUniversityID,
					(attendedUniv, stud) => new
					{
						UniversityID = attendedUniv.UniversityID,
						StudentExtended = stud,
					}),

				univ => univ.UniversityID,
				attendedUniv => attendedUniv.UniversityID,
				(univ, attendedUniv) => new
				{
					UniversityName = univ.UniversityName,
					StudentAtendedUniv = attendedUniv,
				})
				.ToList()
				.Select( univ => new Tuple<string, string>(
						univ.UniversityName,
						string.Join(", ", univ.StudentAtendedUniv.StudentExtended))
						);

			foreach (var univ in allUniversitiesWithAllStudents)
			{
				Console.WriteLine($"{univ.Item1} {univ.Item2}");
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
	}
}
