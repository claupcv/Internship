using CourseExercises.Classes;
using System;

namespace CourseExercises
{
  public partial class InteractiveMenu
  {
    private void SquareMatrixes_ReadFromConsole()
    {
      Console.Clear();

      ConsoleHelper.WriteSeparator("Read a square (n X n) matrix");

      this.squareMatrix = MatrixHelper.ReadSquareMatrixFromConsole();

      this.SquareMatrix_PrintToConsole(false);
    }

    private void SquareMatrix_PrintToConsole(bool clear)
    {
      if (clear)
      {
        Console.Clear();
      }

      ConsoleHelper.WriteSeparator("The read matrix is");

      MatrixHelper.PrintToConsole(this.squareMatrix);

      this.ExerciseEnd_PromptGoBackToMenu("square matrix");
    }

    private void SquareMatrix_SeekAndPrintElement()
    {
      Console.Clear();

      ConsoleHelper.WriteSeparator("Seek an element in a square matrix and print search results");

      int elementToSeek = ConsoleHelper.ReadIntegerFromConsole("Element to seek: ", 0, 10);

      Console.Clear();

      ConsoleHelper.WriteSeparator("The matrix is");

      MatrixHelper.PrintToConsole(this.squareMatrix);

      MatrixHelper.FindElementAndPrintResults(this.squareMatrix, elementToSeek);

      this.ExerciseEnd_PromptGoBackToMenu("square matrix");
    }

    private void SquareMatrix_PrintEven()
    {
      Console.Clear();

      ConsoleHelper.WriteSeparator("The read matrix is");

      MatrixHelper.PrintToConsole(this.squareMatrix);

      ConsoleHelper.WriteSeparator("The even elements are");

      MatrixHelper.PrintEvenElements(this.squareMatrix);

      this.ExerciseEnd_PromptGoBackToMenu("square matrix");
    }

    private void SquareMatrix_PrintOdd()
    {
      Console.Clear();

      ConsoleHelper.WriteSeparator("The read matrix is");

      MatrixHelper.PrintToConsole(this.squareMatrix);

      ConsoleHelper.WriteSeparator("The odd elements are ");

      MatrixHelper.PrintOddElements(this.squareMatrix);

      this.ExerciseEnd_PromptGoBackToMenu("square matrix");
    }

    private void SquareMatrix_RemoveARow()
    {
      Console.Clear();

      ConsoleHelper.WriteSeparator("Print the matrix resulted by removal of a row");

      int rowIdx = ConsoleHelper.ReadIntegerFromConsole("Row index to remove: ", 0, 10);

      Console.Clear();

      ConsoleHelper.WriteSeparator("The matrix is");

      MatrixHelper.PrintToConsole(this.squareMatrix);

      ConsoleHelper.WriteSeparator($"After removing row with index {rowIdx}, the result is");

      int[,] rowRemovedMatrix = MatrixHelper.RemoveRow(this.squareMatrix, rowIdx);

      MatrixHelper.PrintToConsole(rowRemovedMatrix);

      this.ExerciseEnd_PromptGoBackToMenu("square matrix");
    }

    private void SquareMatrix_RemoveACol()
    {
      Console.Clear();

      ConsoleHelper.WriteSeparator("Print the matrix resulted by removal of a column");

      int colIdx = ConsoleHelper.ReadIntegerFromConsole("Column index to remove: ", 0, 10);

      Console.Clear();

      ConsoleHelper.WriteSeparator("The matrix is");

      MatrixHelper.PrintToConsole(this.squareMatrix);

      ConsoleHelper.WriteSeparator($"After removing column with index {colIdx}, the result is");

      int[,] colRemovedMatrix = MatrixHelper.RemoveColumn(this.squareMatrix, colIdx);

      MatrixHelper.PrintToConsole(colRemovedMatrix);

      this.ExerciseEnd_PromptGoBackToMenu("square matrix");
    }

    private void SquareMatrix_RemoveBothRowAndCol()
    {
      Console.Clear();

      ConsoleHelper.WriteSeparator("Print the matrix resulted by removal of a row and a column");

      int rowIdx = ConsoleHelper.ReadIntegerFromConsole("Row index to remove: ", 0, 10);

      int colIdx = ConsoleHelper.ReadIntegerFromConsole("Column index to remove: ", 0, 10);

      Console.Clear();

      ConsoleHelper.WriteSeparator("The matrix is");

      MatrixHelper.PrintToConsole(this.squareMatrix);

      ConsoleHelper.WriteSeparator($"After removing row with index {rowIdx} and column with index {colIdx}, the result is");

      int[,] shrinkedMatrix = MatrixHelper.RemoveRowAndColumn(this.squareMatrix, rowIdx, colIdx);

      MatrixHelper.PrintToConsole(shrinkedMatrix);

      this.ExerciseEnd_PromptGoBackToMenu("square matrix");
    }

    private void SquareMatrix_Determinant()
    {
      Console.Clear();

      ConsoleHelper.WriteSeparator("The read matrix is");

      MatrixHelper.PrintToConsole(this.squareMatrix);

      ConsoleHelper.WriteSeparator("The determinant");

      int determinant = MatrixHelper.Determinant(this.squareMatrix);

      Console.WriteLine($"The determinant is: {determinant}");

      this.ExerciseEnd_PromptGoBackToMenu("square matrix");
    }

    private void SquareMatrix_Transpose()
    {
      Console.Clear();

      ConsoleHelper.WriteSeparator("The read matrix is");

      MatrixHelper.PrintToConsole(this.squareMatrix);

      ConsoleHelper.WriteSeparator("The transpose of the read matrix is");

      int[,] transpose = MatrixHelper.Transpose(this.squareMatrix);

      MatrixHelper.PrintToConsole(transpose);

      this.ExerciseEnd_PromptGoBackToMenu("square matrix");
    }

    private void SquareMatrix_Adjunct()
    {
      Console.Clear();

      ConsoleHelper.WriteSeparator("The read matrix is");

      MatrixHelper.PrintToConsole(this.squareMatrix);

      ConsoleHelper.WriteSeparator("The adjunct of the read matrix is");

      int[,] adjunct = MatrixHelper.Adjunct(this.squareMatrix);

      MatrixHelper.PrintToConsole(adjunct);

      this.ExerciseEnd_PromptGoBackToMenu("square matrix");
    }

    private void SquareMatrix_Invert()
    {
      Console.Clear();

      ConsoleHelper.WriteSeparator("The read matrix is");

      MatrixHelper.PrintToConsole(this.squareMatrix);

      ConsoleHelper.WriteSeparator("The inverse of the read matrix is");

      float[,] invert = MatrixHelper.Invert(this.squareMatrix);

      MatrixHelper.PrintToConsole(invert);

      this.ExerciseEnd_PromptGoBackToMenu("square matrix");
    }

    private void SquareMatrix_SumWithAnother()
    {
      Console.Clear();

      ConsoleHelper.WriteSeparator("Read the other square (n X n) matrix");

      int[,] other = MatrixHelper.ReadFromConsole();

      ConsoleHelper.WriteSeparator("First matrix is");

      MatrixHelper.PrintToConsole(this.squareMatrix);

      ConsoleHelper.WriteSeparator("Second matrix is");

      MatrixHelper.PrintToConsole(other);

      ConsoleHelper.WriteSeparator("The sum (matrix1 + matrix2) is");

      int[,] sum = MatrixHelper.Add(this.squareMatrix, other);

      MatrixHelper.PrintToConsole(sum);

      this.ExerciseEnd_PromptGoBackToMenu("square matrix");
    }

    private void SquareMatrix_DiffWithAnother()
    {
      Console.Clear();

      ConsoleHelper.WriteSeparator("Read the other square (n X n) matrix");

      int[,] other = MatrixHelper.ReadFromConsole();

      ConsoleHelper.WriteSeparator("First matrix is");

      MatrixHelper.PrintToConsole(this.squareMatrix);

      ConsoleHelper.WriteSeparator("Second matrix is");

      MatrixHelper.PrintToConsole(other);

      ConsoleHelper.WriteSeparator("The diff (matrix1 - matrix2) is");

      int[,] diff = MatrixHelper.Substract(this.squareMatrix, other);

      MatrixHelper.PrintToConsole(diff);

      this.ExerciseEnd_PromptGoBackToMenu("square matrix");
    }

    private void SquareMatrix_MultiplyWithAnother()
    {
      Console.Clear();

      ConsoleHelper.WriteSeparator("Read the other square (n X n) matrix");

      int[,] other = MatrixHelper.ReadFromConsole();

      ConsoleHelper.WriteSeparator("First matrix is");

      MatrixHelper.PrintToConsole(this.squareMatrix);

      ConsoleHelper.WriteSeparator("Second matrix is");

      MatrixHelper.PrintToConsole(other);

      ConsoleHelper.WriteSeparator("The prod (matrix1 * matrix2) is");

      int[,] prod = MatrixHelper.Multiply(this.squareMatrix, other);

      MatrixHelper.PrintToConsole(prod);

      this.ExerciseEnd_PromptGoBackToMenu("square matrix");
    }
  }
}
