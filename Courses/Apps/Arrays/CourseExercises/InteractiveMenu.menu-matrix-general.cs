using CourseExercises.Classes;
using System;

namespace CourseExercises
{
  public partial class InteractiveMenu
  {
    private void PromptGeneralMatrixMenu()
    {
      Console.Clear();

      bool isReadGeneralMatrix = (this.generalMatrix != null);

      ConsoleHelper.WriteMenuWithOptionsConditional(
        "General Matrix (n X m) Menu",
        isReadGeneralMatrix,
        new[]
        {
          "To read a general matrix (n X m), type 'read'",
          "To print the read matrix, type 'print'",
          "To seek an element and print position inside read matrix, type 'seek'",
          "To print even elements inside read matrix, type 'even'",
          "To print odd elements inside read matrix, type 'odd'",
          "To print the matrix resulted by removal of a row, type 'rem-row'",
          "To print the matrix resulted by removal of a column, type 'rem-col'",
          "To print the matrix resulted by removal of a row and a column, type 'rem-rc'",
          "To print the transpose of the read matrix, type 'transpose'",
          "To sum the read matrix with another matrix, type 'sum'",
          "To substract another matrix from the read matrix, type 'dif'",
          "To multiply the read matrix with another matrix, type 'prod'",
          "To exit general matrix menu, type 'exit'"
        },
        new[]
        {
          "To read a general matrix (n X m), type 'read'",
          "To exit general matrix menu, type 'exit'"
        });
    }

    private void ReadAndHandleGeneralMatrixMenuOption()
    {
      while (true)
      {
        Console.Write("Please enter your option: ");

        string input = Console.ReadLine();

        if (string.Equals(input, "read", StringComparison.OrdinalIgnoreCase))
        {
          this.GeneralMatrixes_ReadFromConsole();
          this.PromptGeneralMatrixMenu();
        }

        if (string.Equals(input, "print", StringComparison.OrdinalIgnoreCase))
        {
          this.GeneralMatrix_PrintToConsole(true);
          this.PromptGeneralMatrixMenu();
        }

        if (string.Equals(input, "seek", StringComparison.OrdinalIgnoreCase))
        {
          this.GeneralMatrix_SeekAndPrintElement();
          this.PromptGeneralMatrixMenu();
        }

        if (string.Equals(input, "even", StringComparison.OrdinalIgnoreCase))
        {
          this.GeneralMatrix_PrintEven();
          this.PromptGeneralMatrixMenu();
        }

        if (string.Equals(input, "odd", StringComparison.OrdinalIgnoreCase))
        {
          this.GeneralMatrix_PrintOdd();
          this.PromptGeneralMatrixMenu();
        }

        if (string.Equals(input, "rem-row", StringComparison.OrdinalIgnoreCase))
        {
          this.GeneralMatrix_RemoveARow();
          this.PromptGeneralMatrixMenu();
        }

        if (string.Equals(input, "rem-col", StringComparison.OrdinalIgnoreCase))
        {
          this.GeneralMatrix_RemoveACol();
          this.PromptGeneralMatrixMenu();
        }

        if (string.Equals(input, "rem-rc", StringComparison.OrdinalIgnoreCase))
        {
          this.GeneralMatrix_RemoveBothRowAndCol();
          this.PromptGeneralMatrixMenu();
        }

        if (string.Equals(input, "transpose", StringComparison.OrdinalIgnoreCase))
        {
          this.GeneralMatrix_Transpose();
          this.PromptGeneralMatrixMenu();
        }

        if (string.Equals(input, "sum", StringComparison.OrdinalIgnoreCase))
        {
          this.GeneralMatrix_SumWithAnother();
          this.PromptGeneralMatrixMenu();
        }

        if (string.Equals(input, "dif", StringComparison.OrdinalIgnoreCase))
        {
          this.GeneralMatrix_DiffWithAnother();
          this.PromptGeneralMatrixMenu();
        }

        if (string.Equals(input, "prod", StringComparison.OrdinalIgnoreCase))
        {
          this.GeneralMatrix_MultiplyWithAnother();
          this.PromptGeneralMatrixMenu();
        }

        if (string.Equals(input, "exit", StringComparison.OrdinalIgnoreCase))
        {
          break;
        }
      }

      // after exit, go back to matrix menu
      this.PromptMatrixMenu();
    }
  }
}
