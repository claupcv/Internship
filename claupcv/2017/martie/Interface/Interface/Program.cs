using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Clau","PCV");
            ((INameEntity)person).ShowYourself();

            IPresentableEntity student = new Student("John", "Doe", "University of Oradea");
            student.ShowYourself();
            Console.ReadKey();
        }
    }
}
