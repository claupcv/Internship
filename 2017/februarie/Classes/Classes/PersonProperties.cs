using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class PersonProperties
    {
        // Acesta este un camp
        // for encapsulation we can use a property
        private string personName;

        // This is a property that we can control teh acces to it with set, get (same as would be a method)
        public string PersonName
        {
            // acesta este codul care se executa la citire (get)
            get
            {
                return this.personName;
            }
            // acesta este codul care se executa la scriere (set)
            // observati ca IDE-ul ne coloreaza diferit obiectul denumit "value"
            // ca si cum ar fi un cuvant cheie.
            // In contextul operatiunii de set, acesta are o semnificatie speciala
            // este valoarea cu care se incearca scrierea
            // we canuse private for set only, or for get only
            private set
            {
                // nu dorim ca sa permitem cuiva sa seteze campul "personName" 
                // cu valori invalide (null, spatii)
                if (!string.IsNullOrWhiteSpace(value))
                {
                    this.personName = value;
                }
                else
                {
                    this.personName = string.Empty;
                }
            }
            
        }
        // properties - simples sintax of properties
        protected string PersonSurname {get;set;}
        public void PrintNameproperties()
        {
            // acces sintax is same as fields
            Console.WriteLine(this.PersonName);
        }
    }
}
