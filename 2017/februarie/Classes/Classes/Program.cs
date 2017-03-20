using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            // Membrii de instanta si membrii statici
            Console.WriteLine("============Membrii de instanta si membrii statici============");
            // instance
            Person person1 = new Person();
            Person person2 = new Person();

            person1.PrintPopCount();
            person2.PrintPopCount();

            // static
            person1.DoSomethingWithPopulationCount();

            person1.PrintPopCount();
            person2.PrintPopCount();

            Person.PopCount++;
            Console.WriteLine("Now the global population count raised to {0}", Person.PopCount);

            // THIS
            Console.WriteLine("============THIS============");
            PersonInstance personI = new PersonInstance();
            personI.PersonName = "Clau";
            Console.WriteLine("Now the global population count raised to {0}", personI.PersonName);

            // PROPERTIES
            Console.WriteLine("============PROPERTIES============");
            Person personProperties = new Person();
            // din exteriorul clasei
            // sintaxa este foarte asemanatoare cu sintaxa de access la campuri
            personProperties.PersonName = "John Doe";
            Console.WriteLine(personProperties.PersonName);

            // INDEXERS
            Console.WriteLine("============INDEXERS============");
            Indexers indexers = new Indexers();
            // putem utiliza lst folosind accesare dupa index
            // intocmai ca la un array
            Console.WriteLine(indexers[0]);
            Console.WriteLine(indexers[1]);

            Person p = new Person();
            // accesam obiectul "p" folosind o cheie string
            // intocmai ca la un hashtable / dictionar
            Console.WriteLine(indexers["name"]);
            Console.WriteLine(indexers["name1"]);

            // METHODS
            Console.WriteLine("============METHODS============");
            OverloadMethods.Message("Overload : Only string");
            OverloadMethods.Message("Overload : Only string with loop", 5);

            //SINGLETONE allow only 1 instance
            Console.WriteLine("============SINGLETONE============");
            Singleton test = Singleton.Instance;
            Singleton test1 = Singleton.Instance;
            Console.ReadKey();
        }
    }
}
