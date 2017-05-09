using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExcercises
{
    public class AttendedUniversity
    {
		public int AttendedUniversityID { get; set; } = 0;

		public int UniversityID { get; set; } = 0;

        public DateTime RegistrationDate { get; set; } = DateTime.MinValue;

		public DateTime? GraduationDate { get; set; } = new DateTime?();

		public List<int> GradeList = new List<int> { };
		
	}
	
}
