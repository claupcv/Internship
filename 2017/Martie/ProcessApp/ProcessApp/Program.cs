using System;
using System.Diagnostics;

namespace ProcessApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //ConsoleInteratctiveMenu.ConsoleRead(labelInput);
            //ProcessString processString = new ProcessString("String","Testing String!!!");
            //ProcessResult resultExecution = processString.Run();
            //resultExecution.ErrorSuccesMessage();

            ProcessPerson processPerson = new ProcessPerson();
            Console.WriteLine("====================================");
            ProcessResult resultExecution;
            resultExecution = processPerson.Run();

            Console.WriteLine("------------------------------------");
            resultExecution = processPerson.Run();
            resultExecution.ErrorSuccesMessage();

            Console.WriteLine("====================================");
            ProcessPersonException processPersonException = new ProcessPersonException();
            processPersonException.Run();


            //ConsoleInteratctiveMenu mainMenu = new ConsoleInteratctiveMenu();
            //mainMenu.RunMenu();
            Console.ReadKey();
        }
    }
}
