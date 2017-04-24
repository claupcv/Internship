using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    // clasa specializata in printarea de informatii despre persoane
    public static class PersonPrinter
    {
        // tiparire in consola nume persoana
        public static void Print(PersonInstance p)
        {
            Console.WriteLine("The person's name is: " + p.PersonName);
        }
    }

    public partial class PersonInstance
    {
        private const int MinAge = 0;

        // will not work because is a constant and the value have o be known at compilation
        // public const PersonInstance MinAgeInstance = new PersonInstance();

        public string PersonName = "";

        public static int PopulationCount = 0;

        public void Print()
        {
            // printam instanta curenta
            PersonPrinter.Print(this);
        }

    }
}
