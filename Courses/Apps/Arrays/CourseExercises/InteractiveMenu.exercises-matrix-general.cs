using CourseExercises.Classes;
using System;

namespace CourseExercises
{
  public partial class InteractiveMenu
  {
    private void GeneralMatrixes_ReadFromConsole()
    {
      Console.Clear();

      ConsoleHelper.WriteSeparator("Read a general (n X m) matrix");

      this.generalMatrix = MatrixHelper.ReadFromConsole();

      this.GeneralMatrix_PrintToConsole(false);
    }

    private void GeneralMatrix_PrintToConsole(bool clear)
    {
      if (clear)
      {
        Console.Clear();
      }

      ConsoleHelper.WriteSeparator("The read matrix is");

      MatrixHelper.PrintToConsole(this.generalMatrix);

      this.ExerciseEnd_PromptGoBackToMenu("general matrix");
    }

    private void GeneralMatrix_SeekAndPrintElement()
    {
      Console.Clear();

      ConsoleHelper.WriteSeparator("Seek an element in a general matrix and print search results");

      int elementToSeek = ConsoleHelper.ReadIntegerFromConsole("Element to seek: ", 0, 10);

      Console.Clear();

      ConsoleHelper.WriteSeparator("The matrix is");

      MatrixHelper.PrintToConsole(this.generalMatrix);

      MatrixHelper.FindElementAndPrintResults(this.generalMatrix, elementToSeek);

      this.ExerciseEnd_PromptGoBackToMenu("general matrix");
    }

    private void GeneralMatrix_PrintEven()
    {
      Console.Clear();

      ConsoleHelper.WriteSeparator("The read matrix is");

      MatrixHelper.PrintToConsole(this.generalMatrix);

      ConsoleHelper.WriteSeparator("The even elements are");

      MatrixHelper.PrintEvenElements(this.generalMatrix);

      this.ExerciseEnd_PromptGoBackToMenu("general matrix");
    }

    private void GeneralMatrix_PrintOdd()
    {
      Console.Clear();

      ConsoleHelper.WriteSeparator("The read matrix is");

      MatrixHelper.PrintToConsole(this.generalMatrix);

      ConsoleHelper.WriteSeparator("The odd elements are ");

      MatrixHelper.PrintOddElements(this.generalMatrix);

      this.ExerciseEnd_PromptGoBackToMenu("general matrix");
    }

    private void GeneralMatrix_RemoveARow()
    {
      Console.Clear();

      ConsoleHelper.WriteSeparator("Print the matrix resulted by removal of a row");

      int rowIdx = ConsoleHelper.ReadIntegerFromConsole("Row index to remove: ", 0, 10);

      Console.Clear();

      ConsoleHelper.WriteSeparator("The matrix is");

      MatrixHelper.PrintToConsole(this.generalMatrix);

      ConsoleHelper.WriteSeparator($"After removing row with index {rowIdx}, the result is");

      int[,] rowRemovedMatrix = MatrixHelper.RemoveRow(this.generalMatrix, rowIdx);

      MatrixHelper.PrintToConsole(rowRemovedMatrix);

      this.ExerciseEnd_PromptGoBackToMenu("general matrix");
    }

    private void GeneralMatrix_RemoveACol()
    {
      Console.Clear();

      ConsoleHelper.WriteSeparator("Print the matrix resulted by removal of a column");

      int colIdx = ConsoleHelper.ReadIntegerFromConsole("Column index to remove: ", 0, 10);

      Console.Clear();

      ConsoleHelper.WriteSeparator("The matrix is");

      MatrixHelper.PrintToConsole(this.generalMatrix);

      ConsoleHelper.WriteSeparator($"After removing column with index {colIdx}, the result is");

      int[,] colRemovedMatrix = MatrixHelper.RemoveColumn(this.generalMatrix, colIdx);

      MatrixHelper.PrintToConsole(colRemovedMatrix);

      this.ExerciseEnd_PromptGoBackToMenu("general matrix");
    }

    private void GeneralMatrix_RemoveBothRowAndCol()
    {
      Console.Clear();

      ConsoleHelper.WriteSeparator("Print the matrix resulted by removal of a row and a column");

      int rowIdx = ConsoleHelper.ReadIntegerFromConsole("Row index to remove: ", 0, 10);

      int colIdx = ConsoleHelper.ReadIntegerFromConsole("Column index to remove: ", 0, 10);

      Console.Clear();

      ConsoleHelper.WriteSeparator("The matrix is");

      MatrixHelper.PrintToConsole(this.generalMatrix);

      ConsoleHelper.WriteSeparator($"After removing row with index {rowIdx} and column with index {colIdx}, the result is");

      int[,] shrinkedMatrix = MatrixHelper.RemoveRowAndColumn(this.generalMatrix, rowIdx, colIdx);

      MatrixHelper.PrintToConsole(shrinkedMatrix);

      this.ExerciseEnd_PromptGoBackToMenu("general matrix");
    }

    private void GeneralMatrix_Transpose()
    {
      Console.Clear();

      ConsoleHelper.WriteSeparator("The read matrix is");

      MatrixHelper.PrintToConsole(this.generalMatrix);

      ConsoleHelper.WriteSeparator("The transpose of the read matrix is");

      int[,] transpose = MatrixHelper.Transpose(this.generalMatrix);

      MatrixHelper.PrintToConsole(transpose);

      this.ExerciseEnd_PromptGoBackToMenu("general matrix");
    }

    private void GeneralMatrix_SumWithAnother()
    {
      Console.Clear();

      ConsoleHelper.WriteSeparator("Read the other general (n X m) matrix");

      int[,] other = MatrixHelper.ReadFromConsole();

      ConsoleHelper.WriteSeparator("First matrix is");

      MatrixHelper.PrintToConsole(this.generalMatrix);

      ConsoleHelper.WriteSeparator("Second matrix is");

      MatrixHelper.PrintToConsole(other);

      ConsoleHelper.WriteSeparator("The sum (matrix1 + matrix2) is");

      int[,] sum = MatrixHelper.Add(this.generalMatrix, other);

      MatrixHelper.PrintToConsole(sum);

      this.ExerciseEnd_PromptGoBackToMenu("general matrix");
    }

    private void GeneralMatrix_DiffWithAnother()
    {
      Console.Clear();

      ConsoleHelper.WriteSeparator("Read the other general (n X m) matrix");

      int[,] other = MatrixHelper.ReadFromConsole();

      ConsoleHelper.WriteSeparator("First matrix is");

      MatrixHelper.PrintToConsole(this.generalMatrix);

      ConsoleHelper.WriteSeparator("Second matrix is");

      MatrixHelper.PrintToConsole(other);

      ConsoleHelper.WriteSeparator("The diff (matrix1 - matrix2) is");

      int[,] diff = MatrixHelper.Substract(this.generalMatrix, other);

      MatrixHelper.PrintToConsole(diff);

      this.ExerciseEnd_PromptGoBackToMenu("general matrix");
    }

    private void GeneralMatrix_MultiplyWithAnother()
    {
      Console.Clear();

      ConsoleHelper.WriteSeparator("Read the other general (n X m) matrix");

      int[,] other = MatrixHelper.ReadFromConsole();

      ConsoleHelper.WriteSeparator("First matrix is");

      MatrixHelper.PrintToConsole(this.generalMatrix);

      ConsoleHelper.WriteSeparator("Second matrix is");

      MatrixHelper.PrintToConsole(other);

      ConsoleHelper.WriteSeparator("The prod (matrix1 * matrix2) is");

      int[,] prod = MatrixHelper.Multiply(this.generalMatrix, other);

      MatrixHelper.PrintToConsole(prod);

      this.ExerciseEnd_PromptGoBackToMenu("general matrix");
    }
  }
}
