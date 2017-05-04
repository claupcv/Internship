using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLearning
{
    public static class ReturnElementsOperators
    {
        public static void ReturnFirstOrDefaultOperator()
        {
            Console.WriteLine("FirstOperator");

            var set = new[] { 1, 2, 3, 3, 4, 5, 5 };

            var first = set.First();
            Console.WriteLine($"First element in collection: {first}");

            var firstEven = set.First(e => e % 2 == 0);
            Console.WriteLine($"First even element in collection: {firstEven}");

            // va arunca "InvalidOperationException" trebuie folosit "FirstOrDefault"
            var firstBiggerThan5 = set.FirstOrDefault(t => t > 5);
            Console.WriteLine($"First bigger than 5 element in collection: {firstBiggerThan5}");


            var set3 = new Person[0];
            var first3 = set3.FirstOrDefault();
            var foundPersonFormattedString = (first3 != null) ? $"{first3.FirstName} {first3.LastName}" : "null";
            Console.WriteLine($"First (or default) element in 3'rd collection: {foundPersonFormattedString }");

        }

        public static void ReturnElementAtOperator()
        {

            Console.WriteLine("ReturnElementAtOperator");
            var set = new int[] { 1, 2, 3, 4, 5 };
            var result = set.ElementAt(1);
            Console.WriteLine($"Element at index 1 in collection: {result}");
        }
    }
}
