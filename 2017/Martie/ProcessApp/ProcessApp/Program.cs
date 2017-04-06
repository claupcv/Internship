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
            ConsoleInteratctiveMenu.ConsoleWrite("Process person", processPerson.PID.ToString());


            Console.WriteLine("------------------------------------");
            resultExecution = processPerson.Run();
            resultExecution.ErrorSuccesMessage();

            Console.WriteLine("====================================");
            ProcessPersonException processPersonException = new ProcessPersonException();
            processPersonException.Run();

            Console.ReadKey();
        }
    }
}
