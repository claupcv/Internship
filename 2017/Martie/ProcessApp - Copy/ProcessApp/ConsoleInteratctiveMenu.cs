using ProcessApp.Library;
using System;

namespace ProcessApp
{
    class ConsoleInteratctiveMenu
    {
        private void DisplayMainMenuOptions()
        {
            Console.Clear();

            ConsoleHelper.WriteMenuWithOptions(
            "Main Menu",
            new[] 
            {
                "For exercises with vectors, type 'vector'",
                "For exercises with matrixes, type 'matrix'",
                "To exit, type 'exit'"
            });

        }

        private void ReadAndHandleMainMenuOption()
        {
            while (true)
            {
                Console.Write("Please enter your option: ");

                string input = Console.ReadLine();

                if (string.Equals(input, "1", StringComparison.OrdinalIgnoreCase))
                {
                    //this.PromptVectorMenu();
                    //this.ReadAndHandleVectorMenuOption();
                }

                if (string.Equals(input, "matrix", StringComparison.OrdinalIgnoreCase))
                {
                    //this.PromptMatrixMenu();
                    //this.ReadAndHandleMatrixMenuOption();
                }

                if (string.Equals(input, "exit", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
            }
        }

        public void RunMenu()
        {
            this.DisplayMainMenuOptions();

            this.ReadAndHandleMainMenuOption();
        }
    }
}
