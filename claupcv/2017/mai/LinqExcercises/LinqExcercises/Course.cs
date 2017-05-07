using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExcercises
{
	public class Course
	{
        public int CourseID { get; set; } = 0;

		public int UniversityID { get; set; } = 0;

		public string CourseName { get; set; } = "";

		public int CourseYear { get; set; } = 0;

		public int CourseSemester { get; set; } = 0;  
	}
}
