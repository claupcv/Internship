using System;
using System.IO;


namespace HelloWorld
{
    class StaticClass
    {
        public string PersonName="";
        public static int PopulationCount = 0;
        public void PrintPopulationCount()
        {
            // accesam membru static pt. citire
            Console.WriteLine("Population count is: " + StaticClass.PopulationCount);
        }

        public void DoSomethingWithPopulationCount()
        {
            // accesam membru static pt. scriere
            StaticClass.PopulationCount = 100;
        }
    }
    static class StaticClassTest
    {
        static public void StaticClassRun()
        {
            // ...
            // apoi undeva in codul aplicatiei

            StaticClass p1 = new StaticClass();
            StaticClass p2 = new StaticClass();

            // apelam 2 metode de instanta care doar citesc campul static
            // nu avem efecte secundare
            p1.PrintPopulationCount();
            p2.PrintPopulationCount();

            // apelam o metoda de instanta ca si cum am face ceva specific
            // doar instantei p1
            p1.DoSomethingWithPopulationCount();

            // observam ca modificarea campului static a influentat si rezultatul
            // metodei "PrintPopulationCount" apelata pe instanta p2
            p1.PrintPopulationCount();
            p2.PrintPopulationCount();
            //Console.WriteLine(Program.pathToProject);

        }
    }

}
