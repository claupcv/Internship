using System;
using System.Text;
using System.Diagnostics;

namespace Classes
{
    class Destructor
    {
        public string FirstName { get; set; }
 
        public string LastName { get; set; }

        //the constructor
        public Destructor()
        {
            this.FirstName = "PCV";
            this.LastName = "Clau";
            Console.WriteLine("Constructor : First name:{0}, Last name:{1}", this.FirstName, this.LastName);

        }
 
      // ~ used for a user specified destrcutor
        ~Destructor()
        {
            // Output window for showing the destructor message
            Trace.WriteLine("Destructor called");            
        }
    }
}
