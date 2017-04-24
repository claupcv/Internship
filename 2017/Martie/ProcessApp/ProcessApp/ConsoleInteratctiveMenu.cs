using ProcessApp.Library;
using System;

namespace ProcessApp
{
    public static class ConsoleInteratctiveMenu
    {
        public static string ConsoleRead(string inputLabel)
        {
            Console.Write("Input data:{0} = ", inputLabel);
            string inputConsole = Console.ReadLine();
            return inputConsole;           
        }

        public static void ConsoleWrite(string label, string text)
        {
            Console.WriteLine("{0} = {1}", label, text);
        }
    }
}
