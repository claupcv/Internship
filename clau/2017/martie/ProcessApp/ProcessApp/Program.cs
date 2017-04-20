using System;

namespace ProcessApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProcessCore procesCore = new ProcessCore();

            ConsoleInteratctiveMenu mainMenu = new ConsoleInteratctiveMenu();

            mainMenu.RunMenu();

            Console.ReadKey();

        }
    }
}
