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

    public static int[,] Transpose(int[,] matrix)
    {
      if (!MatrixHelper.ValidateMatrix(matrix))
      {
        return new int[0, 0];
      }

      int rows = matrix.GetLength(0),
          cols = matrix.GetLength(1);

      int[,] result = new int[cols, rows];

      for (int i = 0; i < rows; i++)
      {
        for (int j = 0; j < cols; j++)
        {
          result[j, i] = matrix[i, j];
        }
      }

      return result;
    }

    public static int[,] Adjunct(int[,] matrix)
    {
      if (!MatrixHelper.ValidateMatrix(matrix))
      {
        return new int[0, 0];
      }

      int[,] transpose = MatrixHelper.Transpose(matrix);

      if (!MatrixHelper.ValidateMatrix(transpose))
      {
        return new int[0, 0];
      }

      int rows = transpose.GetLength(0),
          cols = transpose.GetLength(1);

      int[,] adjunct = new int[rows, cols];

      for (int i = 0; i < rows; i++)
      {
        for (int j = 0; j < cols; j++)
        {
          int sign = ((i + j) % 2 == 0) ? 1 : -1;

          int minor = MatrixHelper.DeterminantMatrix(MatrixHelper.ZipRowAndColumn(transpose, i, j));

          adjunct[j, i] = sign * minor;
        }
      }

      return adjunct;
    }

    public static int[,] ZipRow(int[,] matrix, int rowIndex)
    {
      if (!MatrixHelper.ValidateMatrix(matrix))
      {
        return new int[0, 0];
      }

      int rows = matrix.GetLength(0),
          cols = matrix.GetLength(1);

      if (rows == 0)
      {
        return matrix;
      }

      if ((rowIndex < 0) || (rowIndex >= rows))
      {
        return matrix;
      }

      int[,] result = new int[rows - 1, cols];

      for (int i = 0; i < rows; i++)
      {
        for (int j = 0; j < cols; j++)
        {
          if (i < rowIndex)
          {
            result[i, j] = matrix[i, j];
          }
          else if (i > rowIndex)
          {
            result[i - 1, j] = matrix[i, j];
          }
        }
      }

      return result;
    }

    public static int[,] ZipColumn(int[,] matrix, int colIndex)
    {
      if (!MatrixHelper.ValidateMatrix(matrix))
      {
        return new int[0, 0];
      }

      int rows = matrix.GetLength(0),
          cols = matrix.GetLength(1);

      if (cols == 0)
      {
        return matrix;
      }

      if ((colIndex < 0) || (colIndex >= cols))
      {
        return matrix;
      }

      int[,] result = new int[rows, cols - 1];

      for (int i = 0; i < rows; i++)
      {
        for (int j = 0; j < cols; j++)
        {
          if (j < colIndex)
          {
            result[i, j] = matrix[i, j];
          }
          else if (j > colIndex)
          {
            result[i, j - 1] = matrix[i, j];
          }
        }
      }

      return result;
    }

    public static int[,] ZipRowAndColumn(int[,] matrix, int rowIndex, int colIndex)
    {
      return MatrixHelper.ZipColumn(MatrixHelper.ZipRow(matrix, rowIndex), colIndex);
    }

    private static int DeterminantMatrix1_1(int[,] matrix)
    {
      if (!MatrixHelper.ValidateMatrix(matrix))
      {
        return 0;
      }

      int rows = matrix.GetLength(0),
          cols = matrix.GetLength(1);

      if ((rows != cols) || (rows != 1))
      {
        return 0;
      }

      return matrix[0, 0];
    }

    private static int DeterminantMatrix2_2(int[,] matrix)
    {
      if (!MatrixHelper.ValidateMatrix(matrix))
      {
        return 0;
      }

      int rows = matrix.GetLength(0),
          cols = matrix.GetLength(1);

      if ((rows != cols) || (rows != 2))
      {
        return 0;
      }

      return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
    }

    public static int DeterminantMatrix(int[,] matrix)
    {
      // Uses Laplace expansion 
      // Inspiration came from: http://www.mathsisfun.com/algebra/matrix-determinant.html
      // See also: https://en.wikipedia.org/wiki/Laplace_expansion

      if (!MatrixHelper.ValidateMatrix(matrix))
      {
        return 0;
      }

      int rows = matrix.GetLength(0),
          cols = matrix.GetLength(1);

      if (rows != cols)
      {
        Console.WriteLine("The matrix is not square");
        return 0;
      }

      if (rows == 1)
      {
        return MatrixHelper.DeterminantMatrix1_1(matrix);
      }
      else if (rows == 2)
      {
        return MatrixHelper.DeterminantMatrix2_2(matrix);
      }
      else
      {
        int det = 0;
        for (int i = 0; i < cols; i++)
        {
          int sign = (i % 2 == 0) ? 1 : (-1);

          det += sign * matrix[0, i] * MatrixHelper.DeterminantMatrix(MatrixHelper.ZipRowAndColumn(matrix, 0, i));
        }

        return det;
      }
    }
  }
}
