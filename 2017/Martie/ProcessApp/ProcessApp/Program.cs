using System;
using System.Diagnostics;

namespace ProcessApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcessFlow processFlow = new ProcessFlow();

            //processFlow.Run("String");

            processFlow.Run(new Person());
            //processFlow.Run(new Person());
            //processFlow.Run(new Person());


            //ConsoleInteratctiveMenu mainMenu = new ConsoleInteratctiveMenu();
            //mainMenu.RunMenu();
            Console.ReadKey();
        }
    }
}
