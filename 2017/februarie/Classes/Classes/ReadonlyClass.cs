using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class ReadonlyPerson
    {
        // Initializarea la declarare este permisa pentru campurile readonly
        public readonly string FirstName, LastName = "";
        public static readonly string FirstNameStatic, LastNameStatic = "";

        public ReadonlyPerson()
        {
            // Initializarea in constructor este permisa pentru campurile readonly
            this.FirstName = "";
            this.LastName = "";
            
        }
        static ReadonlyPerson()
        {
            ReadonlyPerson.LastNameStatic = "";
        }

        public void DoSomethingWithFirstName()
        {
            // acest apel va da eroare
            // Error CS0191 : A readonly field cannot be assigned to(except in a constructor or a variable initializer)
            //this.FirstName = "Test";
        }
    }
}
