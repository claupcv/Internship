using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcessString processString = new ProcessString();
            processString.Run(1);

            //procesCore.Run(" 11");
            //ConsoleInteratctiveMenu mainMenu = new ConsoleInteratctiveMenu();
            //mainMenu.RunMenu();

            Console.ReadKey();
        }
    }
}
