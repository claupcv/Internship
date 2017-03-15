using CourseExercises.Classes;
using System;

namespace CourseExercises
{
  public partial class InteractiveMenu
  {
    private void PromptVectorMenu()
    {
      Console.Clear();

      bool isReadVector = (vector != null);

      ConsoleHelper.WriteMenuWithOptionsConditional(
        "Vector Menu",
        isReadVector,
        new[]
        {
          "To read a vector, type 'read'",
          "To print the read vector, type 'print'",
          "To sum the read vector with another vector, type 'sum'",
          "To substract another vector from the read vector, type 'dif'",
          "To print the the read vector in an ascending sorted order, type 'sort-asc'",
          "To print the the read vector in a descending sorted order, type 'sort-desc'",
          "To seek an element and print position inside read vector, type 'seek'",
          "To print even elements inside read vector, type 'even'",
          "To print odd elements inside read vector, type 'odd'",
          "To print the reverse of the read vector, type 'reverse'",
          "To exit vectors menu, type 'exit'"
        },
        new[]
        {
          "To read a vector, type 'read'",
          "To exit vectors menu, type 'exit'"
        });
    }

    private void ReadAndHandleVectorMenuOption()
    {
      while (true)
      {
        Console.Write("Please enter your option: ");

        string input = Console.ReadLine();

        if (string.Equals(input, "read", StringComparison.OrdinalIgnoreCase))
        {
          this.Vectors_ReadFromConsole();
          this.PromptVectorMenu();
        }

        if (string.Equals(input, "print", StringComparison.OrdinalIgnoreCase))
        {
          this.Vectors_PrintToConsole(true);
          this.PromptVectorMenu();
        }

        if (string.Equals(input, "sum", StringComparison.OrdinalIgnoreCase))
        {
          this.Vectors_SumWithAnother();
          this.PromptVectorMenu();
        }

        if (string.Equals(input, "dif", StringComparison.OrdinalIgnoreCase))
        {
          this.Vectors_DiffWithAnother();
          this.PromptVectorMenu();
        }

        if (string.Equals(input, "sort-asc", StringComparison.OrdinalIgnoreCase))
        {
          this.Vectors_SortAscending();
          this.PromptVectorMenu();
        }

        if (string.Equals(input, "sort-desc", StringComparison.OrdinalIgnoreCase))
        {
          this.Vectors_SortDescending();
          this.PromptVectorMenu();
        }

        if (string.Equals(input, "seek", StringComparison.OrdinalIgnoreCase))
        {
          this.Vectors_SeekAndPrintElement();
          this.PromptVectorMenu();
        }

        if (string.Equals(input, "even", StringComparison.OrdinalIgnoreCase))
        {
          this.Vectors_PrintEven();
          this.PromptVectorMenu();
        }

        if (string.Equals(input, "odd", StringComparison.OrdinalIgnoreCase))
        {
          this.Vectors_PrintOdd();
          this.PromptVectorMenu();
        }

        if (string.Equals(input, "reverse", StringComparison.OrdinalIgnoreCase))
        {
          this.Vectors_Reverse();
          this.PromptVectorMenu();
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
