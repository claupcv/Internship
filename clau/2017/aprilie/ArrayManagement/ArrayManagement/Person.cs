using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManagement
{
    public class Person  : IEquatable<Person>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public override int GetHashCode()
        {
            return (string.IsNullOrEmpty(this.FirstName) ? 0 : this.FirstName.GetHashCode()) ^
                (string.IsNullOrEmpty(this.LastName) ? 0 : this.LastName.GetHashCode()) ^
                (string.IsNullOrEmpty(this.LastName) ? 0 : this.Age.GetHashCode());
        }

        public override bool Equals(object obj)
        {
            return this.Equals(obj as Person);
        }

        public bool Equals(Person other)
        {
            if (other == null)
            {
                return false;
            }
            return string.Equals(this.FirstName, other.FirstName) &&
                string.Equals(this.LastName, other.LastName) &&
                string.Equals(this.Age, other.Age);
        }

        public static bool operator ==(Person p1, Person p2)
        {
            if (object.ReferenceEquals(p1, null) && object.ReferenceEquals(p2, null))
            {
                return true;
            }

            if (object.ReferenceEquals(p1, null) || object.ReferenceEquals(p2, null))
            {
                return false;
            }

            return p1.Equals(p2);
        }

        public static bool operator !=(Person p1, Person p2)
        {
            if (object.ReferenceEquals(p1, null) || object.ReferenceEquals(p2, null))
            {
                return false;
            }

            if (object.ReferenceEquals(p1, null) || object.ReferenceEquals(p2, null))
            {
                return true;
            }

            return !p1.Equals(p2);
        }

    }
}
