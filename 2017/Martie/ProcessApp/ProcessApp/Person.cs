using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessApp
{
    public class Person
    {
        public string FirstName;

        public string LastName;

        public int Age;

        public static int populationCount = 0;
        public Person()
            :this("","",0)
        {

        }

        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            populationCount++;
        }

        public string this[string propertyName]
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(propertyName))
                {
                    switch (propertyName.ToUpper())
                    {
                        case "LASTNAME":
                            return this.LastName;

                        case "FIRSTNAME":
                            return this.FirstName;
                        case "AGE":
                            return this.Age.ToString();
                    }
                }

                return null;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(propertyName))
                {
                    switch (propertyName.ToUpper())
                    {
                        case "LASTNAME":
                            this.LastName = value;
                            break;

                        case "FIRSTNAME":
                            this.FirstName = value;
                            break;

                        case "AGE":
                            this.Age = Int32.Parse(value);
                            break;
                    }
                }
            }
        }
    }
}
