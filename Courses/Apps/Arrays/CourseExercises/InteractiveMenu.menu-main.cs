using CourseExercises.Classes;
using System;

namespace CourseExercises
{
  public partial class InteractiveMenu
  {
    private void PromptMainMenu()
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

        if (string.Equals(input, "vector", StringComparison.OrdinalIgnoreCase))
        {
          this.PromptVectorMenu();
          this.ReadAndHandleVectorMenuOption();
        }

        if (string.Equals(input, "matrix", StringComparison.OrdinalIgnoreCase))
        {
          this.PromptMatrixMenu();
          this.ReadAndHandleMatrixMenuOption();
        }

        if (string.Equals(input, "exit", StringComparison.OrdinalIgnoreCase))
        {
          break;
        }
      }
    }
  }
}
