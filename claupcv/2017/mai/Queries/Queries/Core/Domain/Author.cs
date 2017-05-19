using System.Collections.Generic;
using System;

namespace Queries.Core.Domain
{
    public class Author
    {
        public Author()
        {
            Courses = new HashSet<Course>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Course> Courses { get; set; }

		public DateTime DateOfBirth { get; set; } = DateTime.MinValue;
	}
}
