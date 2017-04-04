using System;

namespace Classes
{
    public partial class PartialClassMethods
    {
        public string FirstName  { get; set; }

        // can't put body of method to all parts of the partial methods
        // give error : Error	1	A partial method may not have multiple implementing declarations

        partial void Partialmethod();
        //{ Console.WriteLine("Partial class 2");  }


    }
}
