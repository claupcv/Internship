using System;

namespace CourseExercises.Classes
{
  public static class MatrixHelper
  {
    private static int[,] ReadMatrixOfDimensions(int rows, int cols)
    {
      if (rows < 0)
      {
        rows = 0;
      }

      if (cols < 0)
      {
        cols = 0;
      }

      int[,] matrix = new int[rows, cols];
      for (int i = 0; i < rows; i++)
      {
        for (int j = 0; j < cols; j++)
        {
          int element = ConsoleHelper.ReadIntegerFromConsole($"Element at [{i},{j}]: ", 0, 10);

          matrix[i, j] = element;
        }
      }

      return matrix;
    }

    private static bool ValidateMatrix(int[,] matrix)
    {
      if (matrix == null)
      {
        Console.WriteLine("The matrix is null");
        return false;
      }

      int rows = matrix.GetLength(0);
      if (rows == 0)
      {
        Console.WriteLine("The matrix has 0 rows");
        return false;
      }

      int cols = matrix.GetLength(1);
      if (cols == 0)
      {
        Console.WriteLine("The matrix has 0 columns");
        return false;
      }

      return true;
    }

    public static int[,] ReadFromConsole()
    {
      int rows = ConsoleHelper.ReadIntegerFromConsole("Number of rows: ", 0, 10);

      int cols = ConsoleHelper.ReadIntegerFromConsole("Number of columns: ", 0, 10);

      return MatrixHelper.ReadMatrixOfDimensions(rows, cols);
    }

    public static int[,] ReadSquareMatrixFromConsole()
    {
      int rows = ConsoleHelper.ReadIntegerFromConsole("Dimension: ", 0, 10);

      return MatrixHelper.ReadMatrixOfDimensions(rows, rows);
    }

    public static void PrintToConsole(int[,] matrix)
    {
      if (!MatrixHelper.ValidateMatrix(matrix))
      {
        return;
      }

      int rows = matrix.GetLength(0),
          cols = matrix.GetLength(1);

      for (int i = 0; i < rows; i++)
      {
        for (int j = 0; j < cols; j++)
        {
          int element = matrix[i, j];

          ConsoleHelper.WriteValueFixedWidth(element, 5);
        }

        Console.WriteLine();
      }
    }

    public static void FindElement(int[,] matrix, int element)
    {
      if (!MatrixHelper.ValidateMatrix(matrix))
      {
        return;
      }

      int rows = matrix.GetLength(0),
          cols = matrix.GetLength(1);

      bool found = false;
      for (int i = 0; i < rows; i++)
      {
        for (int j = 0; j < cols; j++)
        {
          int value = matrix[i, j];
          if (value == element)
          {
            Console.WriteLine($"Element {element} found at coords [{i},{j}]");
            found = true;
            break;
          }
        }

        Console.WriteLine();
      }

      if (!found)
      {
        Console.WriteLine($"Element {element} was not found!");
      }
    }

    public static void PrintOddElements(int[,] matrix)
    {
      if (!MatrixHelper.ValidateMatrix(matrix))
      {
        return;
      }

      int rows = matrix.GetLength(0),
          cols = matrix.GetLength(1);

      Console.Write("Odd elements: ");

      for (int i = 0; i < rows; i++)
      {
        for (int j = 0; j < cols; j++)
        {
          int value = matrix[i, j];
          if (value % 2 != 0)
          {
            Console.Write($"{value}, ");
          }
        }
      }

      Console.WriteLine();
    }

    public static void PrintEvenElements(int[,] matrix)
    {
      if (!MatrixHelper.ValidateMatrix(matrix))
      {
        return;
      }

      int rows = matrix.GetLength(0),
          cols = matrix.GetLength(1);

      Console.Write("Even elements: ");

      for (int i = 0; i < rows; i++)
      {
        for (int j = 0; j < cols; j++)
        {
          int value = matrix[i, j];
          if (value % 2 == 0)
          {
            Console.Write($"{value}, ");
          }
        }
      }

      Console.WriteLine();
    }
  }
}
