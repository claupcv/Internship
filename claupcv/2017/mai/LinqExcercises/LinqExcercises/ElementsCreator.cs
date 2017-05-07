using System;
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
            var persons = new Person[]
            {
                new Person()
                {
                    PersonID = 1,
                    FirstName = "John",
                    LastName = "Doe",
                    Age = 20,
                    BirthDay = new DateTime(1988, 3, 25)
                },
                new Student()
                {
                    PersonID = 2,
                    FirstName = "John",
                    LastName = "Doe",
                    Age = 22,
                    BirthDay = new DateTime(1985, 5, 2),
                    UniversityID = new List<int> {1,3,5}
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
                    UniversityID = 1,
                    UniversityName = "University of London",
                    Address = "London street 1",
                }
            };

            return universities;
        }
    }
}
