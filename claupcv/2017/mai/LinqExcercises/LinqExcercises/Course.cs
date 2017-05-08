using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExcercises
{
	public class Course : IEquatable<Course>
	{
        public int CourseID { get; set; } = 0;

		public int UniversityID { get; set; } = 0;

		public string CourseName { get; set; } = "";

		public int CourseYear { get; set; } = 0;

		public int CourseSemester { get; set; } = 0;


		public bool Equals(Course other)
		{
			if (this.CourseName == other.CourseName)
			{
				return true;
			}
			return false;
		}

		public override int GetHashCode()
		{
			int hashCourseName = this.CourseName == null ? 0 : this.CourseName.GetHashCode();

			return hashCourseName;
		}
	}
}
