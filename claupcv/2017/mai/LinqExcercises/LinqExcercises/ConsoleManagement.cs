﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExcercises
{
	public static class ConsoleManagement
	{
		public static void ForeachShowPersonsToConsole(IEnumerable<Person>  persons)
		{
			foreach (var person in persons)
			{
				Console.WriteLine($"Name = {person.FirstName} {person.LastName}; " +
					$"BirthDay = {person.BirthDay.ToString("dd/MM/yyyy")};");
			}
			Console.WriteLine("==================================================");
		}

		public static void ForeachShowStudentsToConsole(IEnumerable<Student> students)
		{
			foreach (var person in students)
			{
				Console.WriteLine($"Name = {person.FirstName} {person.LastName}; " +
					$"BirthDay = {person.BirthDay.ToString("dd/MM/yyyy")};");
			}
			Console.WriteLine("==================================================");
		}

		public static void ForeachShowCoursesToConsole(IEnumerable<Course> courses)
		{
			foreach (var course in courses)
			{
				Console.WriteLine($"Course = {course.CourseName}; " +
					$"Course year = {course.CourseYear}; " +
					$"Course semester = {course.CourseSemester};");
			}
			Console.WriteLine("==================================================");
		}

		public static void ForeachShowAllStudentsToAllUniverisites(IEnumerable<University> allUniversitiesWithAllStudents)
		{
			foreach (var univ in allUniversitiesWithAllStudents)
			{
				Console.WriteLine($"Course = {univ.UniversityName}; " +
					$"UniveristyName = {univ.UniversityName};" );
			}
			Console.WriteLine("==================================================");
		}
	}
}
