using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessApp
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int populationCount = 0;

        public Person()
        {
            this.FirstName = string.Empty;
            this.LastName = string.Empty;
            this.Age = 0;
            this.populationCount++;
        }

        public void Run(string firstName, string lastName, int age)
        {

        }

    }
}
