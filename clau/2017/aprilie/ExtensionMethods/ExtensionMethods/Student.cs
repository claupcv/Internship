using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public class Student: Person
    {
        public string UniversityName { get; private set; }

        public Student(
            string firstName = "",
            string lastName = "",
            string universityName = "")
                : base(firstName, lastName)
            {
                this.UniversityName = universityName;
            }


    }
}
