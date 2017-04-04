using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Person : INameEntity, IPresentableEntity
    {
        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public Person()
            :this("","")
        {

        }

        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;

            this.LastName = lastName;
        }

        void IPresentableEntity.ShowYourself()
        {
            Console.WriteLine("Hello, {0} {1}, this is method : IPresentableEntity?", this.FirstName, this.LastName);
        }

        void INameEntity.ShowYourself()
        {
            Console.WriteLine("Hello, {0} {1}, this is method : IPresentableEntity?", this.FirstName, this.LastName);
        }
    }
}
