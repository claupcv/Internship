using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingParameters
{
    class Program
    {
        
        void ChangePersonName(PersonPassingParameters person)
        {

            // person was send by reference(010011001000100001110011 - the stack adress of the person instance from the heap
            person.FirstName = "Changed John";
            //person.LastName = "Changed DOE";
            PersonPassingParameters personNew = new PersonPassingParameters("New","Test");
            Console.WriteLine("Inside ChangePersonName :: full name = '{0} {1}'", personNew.FirstName, personNew.LastName);
        }

        static void Main(string[] args)
        {
            // sending by reference a reference value
            Console.WriteLine("sending by reference a reference value");
            PersonPassingParameters person = new PersonPassingParameters("Clau", "PCV");
            Console.WriteLine("Before ChangePersonName :: full name = '{0} {1}'", person.FirstName, person.LastName);
            Program program = new Program();
            program.ChangePersonName(person);
            Console.WriteLine("After ChangePersonName :: full name = '{0} {1}'", person.FirstName, person.LastName);

            // Using 'REF' example
            Console.WriteLine("=====================================================");
            Console.WriteLine("Using 'REF' example");
            PersonRefParameter personRef = new PersonRefParameter();
            int i=5;
            Console.WriteLine("Before Increment :: i={0}", i);
            personRef.Increment(ref i);
            Console.WriteLine("After Outside Increment :: i={0}", i);            

            Console.WriteLine("=====================================================");
            Console.WriteLine("Using 'OUT' example");

            int count = 10;
            int incremented;
            Console.WriteLine("Before Increment :: count={0}", count);
            PersonOutParameter personOut = new PersonOutParameter();
            personOut.IncrementOutExample(count, out incremented);
            Console.WriteLine("After Increment :: incremented={0}", incremented);

            Console.WriteLine("=====================================================");
            Console.WriteLine("Using 'OUT' example");

            IndeterminateNumberOfParameters param = new IndeterminateNumberOfParameters();
            param.Run();

            Console.ReadKey();
        }
    }
}
