using CourseExercises.Classes;
using System;

namespace CourseExercises
{
  public partial class InteractiveMenu
  {
    private void PromptMatrixMenu()
    {
      Console.Clear();

      ConsoleHelper.WriteMenuWithOptions(
        "Matrix Menu",
        new[]
        {
          "For exercises with general (n X m) matrixes, type 'general'",
          "For exercises with square (n X n) matrixes, type 'square'",
          "To exit matrix menu, type 'exit'"
        });
    }

    private void ReadAndHandleMatrixMenuOption()
    {
      while (true)
      {
        Console.Write("Please enter your option: ");

        string input = Console.ReadLine();

        if (string.Equals(input, "general", StringComparison.OrdinalIgnoreCase))
        {
          this.PromptGeneralMatrixMenu();
          this.ReadAndHandleGeneralMatrixMenuOption();
        }

        if (string.Equals(input, "square", StringComparison.OrdinalIgnoreCase))
        {
          this.PromptSquareMatrixMenu();
          this.ReadAndHandleSquareMatrixMenuOption();
        }

        if (string.Equals(input, "exit", StringComparison.OrdinalIgnoreCase))
        {
          break;
        }
      }

      // after exit, go back to main menu
      this.PromptMainMenu();
    }
  }
}
