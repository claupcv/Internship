using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs11apr
{
    class Program
    {

        static void EqualityOperatorOverloadRun()
        {
            var pp1 = new Person
            {
                FirstName = "John",
                LastName = "Doe",
                DateOfBirth = new DateTime(1975, 1, 1)

            };

            var pp2 = new Person
            {
                FirstName = "John",
                LastName = "Doe",
                DateOfBirth = new DateTime(1975, 1, 1)

            };

            var areEqual = (pp1 == pp2);

            Console.WriteLine(areEqual ? "P1 is equal P2" : "P1 is not equal to P2");
        }

        static void TypeMetadataRun()
        {
            //Types
            string obj1 = "test";
            int obj2 = 10;

            Console.WriteLine(
                TypeMetadata.IsInteger(obj1) ? "obj1 is int" : "obj1 is NOT int");
            Console.WriteLine(
                TypeMetadata.IsInteger(obj2) ? "obj2 is int" : "obj2 is NOT int");
        }

        static void DynamicTypeRun()
        {
            dynamic obj = DynamicType.CreateDinamic();
            DynamicType.ReadDinamic(obj);
        }

        static void anonymousInstanceRun()
        {
            // Anonymus type
            var anonymousInstance = new { FirstName = "John", LastName = "Doe", Age = 25 };

            Console.WriteLine(anonymousInstance.GetType());
        }

        static void ExceptionsRun()
        {
            Person p1 = null;
            ExceptionExamples.MethodThatEncuntersAnException(p1);

            Person p2 = new Person { FirstName = "John" };
            ExceptionExamples.MethodThatEncuntersAnException(p2);
            Console.ReadKey();
        }
        
        static void Main(string[] args)
        {

            anonymousInstanceRun();

            Console.ReadKey();

        }
    }
}
