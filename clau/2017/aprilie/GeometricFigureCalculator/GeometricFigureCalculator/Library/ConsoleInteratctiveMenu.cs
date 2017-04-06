using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigureCalculator.Library
{
    public static class ConsoleInteratctiveMenu
    {
        public static string ConsoleRead(string inputLabel)
        {
            Console.Write("{0} = ", inputLabel);
            string inputConsole = Console.ReadLine();
            return inputConsole;
        }
    }
}
