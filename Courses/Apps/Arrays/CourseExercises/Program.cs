using CourseExercises.Classes;

namespace CourseExercises
{
  class Program
  {
    static void Main(string[] args)
    {
      // Vector

      ConsoleHelper.WriteSeparator("Read a vector");

      int[] array = VectorHelper.ReadFromConsole();

      ConsoleHelper.WriteSeparator("Print a vector");

      VectorHelper.PrintToConsole(array);

      ConsoleHelper.WriteSeparator("Seek an element in a vector");

      int elementToSeekVector = ConsoleHelper.ReadIntegerFromConsole("Value to seek: ", 0, 10);

      VectorHelper.FindElement(array, elementToSeekVector);

      ConsoleHelper.WriteSeparator("Odd and even elements the vector");

      VectorHelper.PrintOddElements(array);
      VectorHelper.PrintEvenElements(array);

      ConsoleHelper.WriteSeparator("Reverse the vector");

      int[] reversedArray = VectorHelper.Reverse(array);

      VectorHelper.PrintToConsole(reversedArray);

      // Matrix

      ConsoleHelper.WriteSeparator("Read a matrix (general)");

      int[,] matrix = MatrixHelper.ReadFromConsole();

      ConsoleHelper.WriteSeparator("Print a matrix (general)");

      MatrixHelper.PrintToConsole(matrix);

      ConsoleHelper.WriteSeparator("Read a matrix (square)");

      int[,] squareMatrix = MatrixHelper.ReadSquareMatrixFromConsole();

      ConsoleHelper.WriteSeparator("Print a matrix (square)");

      MatrixHelper.PrintToConsole(squareMatrix);

      ConsoleHelper.WriteSeparator("Seek an element in a square matrix");

      int elementToSeekMatrix = ConsoleHelper.ReadIntegerFromConsole("Value to seek: ", 0, 10);

      MatrixHelper.FindElement(squareMatrix, elementToSeekMatrix);

      ConsoleHelper.WriteSeparator("Odd and even elements in the square matrix");

      MatrixHelper.PrintOddElements(squareMatrix);
      MatrixHelper.PrintEvenElements(squareMatrix);
    }
  }
}
