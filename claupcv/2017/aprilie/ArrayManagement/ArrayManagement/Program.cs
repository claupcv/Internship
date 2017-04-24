using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManagement
{
    class Program
    {
        static void Main(string[] args)
        {

            //Person person1 = new Person("Clau1", "PCV1", 10);
            //Person person2 = new Person("Clau2", "PCV2", 20);
            //Person person3 = new Person("Clau3", "PCV3", 30);
            int[] arrayExample = new int[5] { 2, 4, 1, 5, 3 };
            ArrayHelper<int> arrayHelper = new ArrayHelper<int>(arrayExample);
            Console.WriteLine(arrayHelper.SearchIndexOf(2));

            Person[] Persons = { 
                                   new Person("Clau1", "PCV1", 10), 
                                   new Person("Clau2", "PCV2", 20), 
                                   new Person("Clau3", "PCV3", 30) 
                               };
            ArrayHelper<Person> arrayHelperPerson = new ArrayHelper<Person>(Persons);
            
            Console.WriteLine(arrayHelperPerson.SearchIndexOf(new Person("Clau2", "PCV2", 20)));
            var elem = arrayHelperPerson.GetElemByIndex(1);
            Console.WriteLine("Name : {0} {1}, Age : {2};", elem.FirstName, elem.LastName, elem.Age);


            string text = "My name is claudiu!";
            char[] charArrayText = text.ToCharArray();
            ArrayHelper<char> arrayHelperChar = new ArrayHelper<char>(charArrayText);
            Console.WriteLine(arrayHelperChar.GetRowLength());
            Console.WriteLine("GetElemByIndex : {0}",arrayHelperChar.GetElemByIndex(9));
            arrayHelperChar.printArrayToConsole();
            Console.ReadKey();
        }
    }
}
