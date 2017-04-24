using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class ClassInheritanceParent
    {
        public string FirstName { get; private set; }
 
        public string LastName { get; private set; }
 
        public ClassInheritanceParent()
            : this("", "")
        {
        }

        public ClassInheritanceParent(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }

    public class ClassInheritanceChild : ClassInheritanceParent
    {
        public string UniversityName { get; private set; }

        public ClassInheritanceChild()
            : this("", "", "")
        {
 
        }
 
        public ClassInheritanceChild(string firstName, string lastName, string universityName)
            : base(firstName, lastName)
        {
            this.UniversityName = universityName;
        }
    }
}
