using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Student : Person, IPresentableEntity
    {
        public string UniversityName { get; set; }

        public Student(string firstName, string lastName, string universityName)
            : base(firstName, lastName)
        {
            this.UniversityName = universityName;
        }

        void IPresentableEntity.PresentYourself()
        {
            Console.WriteLine("Hello, my name is {0} {1}, and I am a student at {2} ...",this.FirstName, this.LastName ,this.UniversityName);
        }

    }
}
