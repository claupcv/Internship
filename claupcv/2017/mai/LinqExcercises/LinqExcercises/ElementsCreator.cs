﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExcercises
{
	public static class ElementsCreator
	{
		public static Person[] CreatePersonsAndStudents()
		{
			var persons = new[]
			{
				new Person()
				{
					PersonID = 1,
					FirstName = "John",
					LastName = "Doe",
					Age = 20,
					BirthDay = new DateTime(1988, 3, 25)
				},

				new Person()
				{
					PersonID = 2,
					FirstName = "Gennie",
					LastName = "Holcomb",
					Age = 21,
					BirthDay = new DateTime(1987, 3, 12)
				},

				new Person()
				{
					PersonID = 3,
					FirstName = "Monika",
					LastName = "Demayo",
					Age = 22,
					BirthDay = new DateTime(1986, 1, 2)
				},

				new Person()
				{
					PersonID = 4,
					FirstName = "Deann",
					LastName = "Lorraine",
					Age = 24,
					BirthDay = new DateTime(1985, 11, 21)
				},

				new Student()
				{
					PersonID = 11,
					FirstName = "John",
					LastName = "Doe",
					Age = 22,
					BirthDay = new DateTime(1985, 5, 2),
					UniversityIDs = new List<int> {1,3,5}
				}


			};

			return persons;
		}

		public static University[] CreateUniversities()
		{
			var universities = new University[]
			{
				new University()
				{
					UniversityID = 1,
					UniversityName = "University of California",
					Address = "California Avenue",
				},
				new University()
				{
					UniversityID = 2,
					UniversityName = "University of London",
					Address = "London street 1",
				}
			};

			return universities;
		}

		public static Course[] CreateCourses()
		{
			var courses = new Course[]
			{
				new Course()
				{
					CourseID = 1,
					UniversityID = 1,
					CourseName = "English",
					CourseYear = 2,
					CourseSemester = 1,
				},

				new Course()
				{
					CourseID = 2,
					UniversityID = 1,
					CourseName = "Math",
					CourseYear = 2,
					CourseSemester = 1,
				},

				new Course()
				{
					CourseID = 3,
					UniversityID = 1,
					CourseName = "Math",
					CourseYear = 2,
					CourseSemester = 2,
				},

				new Course()
				{
					CourseID = 5,
					UniversityID = 1,
					CourseName = "Gym",
					CourseYear = 1,
					CourseSemester = 2,
				},
			};

			return courses;
		}
    }
}
