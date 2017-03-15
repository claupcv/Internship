using CourseExercises.Classes;
using System;

namespace CourseExercises
{
  public partial class InteractiveMenu
  {
    private void PromptSquareMatrixMenu()
    {
      Console.Clear();

      bool isReadSquareMatrix = (this.squareMatrix != null);

      ConsoleHelper.WriteMenuWithOptionsConditional(
        "Square Matrix (n X n) Menu",
        isReadSquareMatrix,
        new[]
        {
          "To read a square matrix (n X n), type 'read'",
          "To print the read matrix, type 'print'",
          "To seek an element and print position inside read matrix, type 'seek'",
          "To print even elements inside read matrix, type 'even'",
          "To print odd elements inside read matrix, type 'odd'",
          "To print the determinant of the read matrix, type 'det'",
          "To print the matrix resulted by removal of a row, type 'rem-row'",
          "To print the matrix resulted by removal of a column, type 'rem-col'",
          "To print the matrix resulted by removal of a row and a column, type 'rem-rc'",
          "To print the transpose of the read matrix, type 'transpose'",
          "To print the adjunct of the read matrix, type 'adjunct'",
          "To print the inverse of the read matrix, type 'invert'",
          "To sum the read matrix with another matrix, type 'sum'",
          "To substract another matrix from the read matrix, type 'dif'",
          "To multiply the read matrix with another matrix, type 'prod'",
          "To exit general matrix menu, type 'exit'"
        },
        new[]
        {
          "To read a square matrix (n X n), type 'read'",
          "To exit general matrix menu, type 'exit'"
        });
    }

    private void ReadAndHandleSquareMatrixMenuOption()
    {
      while (true)
      {
        Console.Write("Please enter your option: ");

        string input = Console.ReadLine();

        if (string.Equals(input, "read", StringComparison.OrdinalIgnoreCase))
        {
          this.SquareMatrixes_ReadFromConsole();
          this.PromptSquareMatrixMenu();
        }

        if (string.Equals(input, "print", StringComparison.OrdinalIgnoreCase))
        {
          this.SquareMatrix_PrintToConsole(true);
          this.PromptSquareMatrixMenu();
        }

        if (string.Equals(input, "seek", StringComparison.OrdinalIgnoreCase))
        {
          this.SquareMatrix_SeekAndPrintElement();
          this.PromptSquareMatrixMenu();
        }

        if (string.Equals(input, "even", StringComparison.OrdinalIgnoreCase))
        {
          this.SquareMatrix_PrintEven();
          this.PromptSquareMatrixMenu();
        }

        if (string.Equals(input, "odd", StringComparison.OrdinalIgnoreCase))
        {
          this.SquareMatrix_PrintOdd();
          this.PromptSquareMatrixMenu();
        }

        if (string.Equals(input, "det", StringComparison.OrdinalIgnoreCase))
        {
          this.SquareMatrix_Determinant();
          this.PromptSquareMatrixMenu();
        }

        if (string.Equals(input, "rem-row", StringComparison.OrdinalIgnoreCase))
        {
          this.SquareMatrix_RemoveARow();
          this.PromptSquareMatrixMenu();
        }

        if (string.Equals(input, "rem-col", StringComparison.OrdinalIgnoreCase))
        {
          this.SquareMatrix_RemoveACol();
          this.PromptSquareMatrixMenu();
        }

        if (string.Equals(input, "rem-rc", StringComparison.OrdinalIgnoreCase))
        {
          this.SquareMatrix_RemoveBothRowAndCol();
          this.PromptSquareMatrixMenu();
        }

        if (string.Equals(input, "transpose", StringComparison.OrdinalIgnoreCase))
        {
          this.SquareMatrix_Transpose();
          this.PromptSquareMatrixMenu();
        }

        if (string.Equals(input, "adjunct", StringComparison.OrdinalIgnoreCase))
        {
          this.SquareMatrix_Adjunct();
          this.PromptSquareMatrixMenu();
        }

        if (string.Equals(input, "invert", StringComparison.OrdinalIgnoreCase))
        {
          this.SquareMatrix_Invert();
          this.PromptSquareMatrixMenu();
        }

        if (string.Equals(input, "sum", StringComparison.OrdinalIgnoreCase))
        {
          this.SquareMatrix_SumWithAnother();
          this.PromptSquareMatrixMenu();
        }

        if (string.Equals(input, "dif", StringComparison.OrdinalIgnoreCase))
        {
          this.SquareMatrix_DiffWithAnother();
          this.PromptSquareMatrixMenu();
        }

        if (string.Equals(input, "prod", StringComparison.OrdinalIgnoreCase))
        {
          this.SquareMatrix_MultiplyWithAnother();
          this.PromptSquareMatrixMenu();
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
