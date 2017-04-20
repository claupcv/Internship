using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Clau", "PCV", 34);

            Tuple<string, Person> tuplu = new Tuple<string,Person>("hey",person);
            tuplu.ShowAttributes();

            // Equality check
            var areEqual2 = EqualityChecker.AreEqual(12, "string 2");

            // Sorter
            var intSorter = new Sorter<int>(2, 5, 3, 1, 4);
            var sortedArray = intSorter.SortAscending();
            foreach (int element in sortedArray)
            {
                Console.Write(element + ",");
            }

            var intFinder = new ElementFinder<int>(2, 5, 3, 1, 4);
            int intElement1;
            bool intLookup1 = intFinder.FindByIndex(2, out intElement1);
            // will print: Int lookup 1: found=True, element=3
            Console.WriteLine("Int lookup 1: found={0}, element={1}", intLookup1, intElement1);

            var stringFinder = new ElementFinder<string>("str1", "str2", "str3");
  	
            string strElement1;
            bool strLookup1 = stringFinder.FindByIndex(2, out strElement1);
            // will print: String lookup 1: found=True, element=str3
            Console.WriteLine("String lookup 1: found={0}, element={1}", strLookup1, strElement1??"(null)");


            Console.ReadKey();
        }
    }
}
