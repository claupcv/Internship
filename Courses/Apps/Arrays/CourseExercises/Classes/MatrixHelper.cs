using System;

namespace CourseExercises.Classes
{
  /// <summary>
  /// Helper class used when working with matrixes
  /// </summary>
  public static class MatrixHelper
  {
    /// <summary>
    /// Fixed width to use for display, when working with matrices with int elements
    /// </summary>
    private const int DisplayFixedWidth_int = 5;

    /// <summary>
    /// Fixed width to use for display, when working with matrices float elements
    /// </summary>
    private const int DisplayFixedWidth_float = 7;

    /// <summary>
    /// Reads from console the elements for the specified matrix (rows X cols)
    /// </summary>
    /// <param name="rows">The number of rows</param>
    /// <param name="cols">The number of columns</param>
    /// <returns>The matrix filled with read elements</returns>
    private static int[,] ReadMatrixElementsFromConsole(int rows, int cols)
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

    /// <summary>
    /// Returns a boolean value indicating whether the matrix is valid (is not null, and has a valid size)
    /// </summary>
    /// <param name="matrix">The matrix</param>
    /// <returns>True if the matrix is valid, false otherwise</returns>
    private static bool IsMatrixValid(int[,] matrix)
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

    /// <summary>
    /// Returns a boolean value indicating whether the matrix is valid (is not null, and has a valid size)
    /// </summary>
    /// <param name="matrix">The matrix</param>
    /// <returns>True if the matrix is valid, false otherwise</returns>
    private static bool IsMatrixValid(float[,] matrix)
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

    /// <summary>
    /// Reads a general matrix (n X m) from console
    /// </summary>
    /// <returns>The matrix, as read from console</returns>
    public static int[,] ReadFromConsole()
    {
      int rows = ConsoleHelper.ReadIntegerFromConsole("Number of rows: ", 0, 10);

      int cols = ConsoleHelper.ReadIntegerFromConsole("Number of columns: ", 0, 10);

      return MatrixHelper.ReadMatrixElementsFromConsole(rows, cols);
    }

    /// <summary>
    /// Reads a square matrix (n X n) from console
    /// </summary>
    /// <returns>The square matrix, as read from console</returns>
    public static int[,] ReadSquareMatrixFromConsole()
    {
      int rows = ConsoleHelper.ReadIntegerFromConsole("Dimension: ", 0, 10);

      return MatrixHelper.ReadMatrixElementsFromConsole(rows, rows);
    }

    /// <summary>
    /// Prints a matrix to console
    /// </summary>
    /// <param name="matrix">The matrix</param>
    public static void PrintToConsole(int[,] matrix)
    {
      if (!MatrixHelper.IsMatrixValid(matrix))
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

          ConsoleHelper.WriteValueFixedWidth(element, MatrixHelper.DisplayFixedWidth_int);
        }

        Console.WriteLine();
      }
    }

    /// <summary>
    /// Prints a matrix to console
    /// </summary>
    /// <param name="matrix">The matrix</param>
    public static void PrintToConsole(float[,] matrix)
    {
      if (!MatrixHelper.IsMatrixValid(matrix))
      {
        return;
      }

      int rows = matrix.GetLength(0),
          cols = matrix.GetLength(1);

      for (int i = 0; i < rows; i++)
      {
        for (int j = 0; j < cols; j++)
        {
          float element = matrix[i, j];

          ConsoleHelper.WriteValueFixedWidth(element, MatrixHelper.DisplayFixedWidth_float);
        }

        Console.WriteLine();
      }
    }

    /// <summary>
    /// Locates an element in a matrix and prints the search result
    /// </summary>
    /// <param name="matrix">The matrix</param>
    /// <param name="element">The element to find</param>
    public static void FindElementAndPrintResults(int[,] matrix, int element)
    {
      if (!MatrixHelper.IsMatrixValid(matrix))
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

    /// <summary>
    /// Prints all the odd elements from a matrix
    /// </summary>
    /// <param name="matrix">The matrix</param>
    public static void PrintOddElements(int[,] matrix)
    {
      if (!MatrixHelper.IsMatrixValid(matrix))
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

    /// <summary>
    /// Prints all even elements from a matrix
    /// </summary>
    /// <param name="matrix">The matrix</param>
    public static void PrintEvenElements(int[,] matrix)
    {
      if (!MatrixHelper.IsMatrixValid(matrix))
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

    /// <summary>
    /// Removes the specified row from the matrix and returns the result matrix
    /// </summary>
    /// <param name="matrix">The matrix</param>
    /// <param name="rowIndex">The index of the row to eliminate</param>
    /// <returns>The result matrix, having the specified row eliminated</returns>
    public static int[,] RemoveRow(int[,] matrix, int rowIndex)
    {
      if (!MatrixHelper.IsMatrixValid(matrix))
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

    /// <summary>
    /// Removes the specified column from the matrix and returns the result matrix
    /// </summary>
    /// <param name="matrix">The matrix</param>
    /// <param name="colIndex">The index of the column to eliminate</param>
    /// <returns>The result matrix, having the specified column eliminated</returns>
    public static int[,] RemoveColumn(int[,] matrix, int colIndex)
    {
      if (!MatrixHelper.IsMatrixValid(matrix))
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

    /// <summary>
    /// Removes the specified row and column from the matrix and returns the result matrix
    /// </summary>
    /// <param name="matrix">The matrix</param>
    /// <param name="rowIndex">The index of the row to eliminate</param>
    /// <param name="colIndex">The index of the column to eliminate</param>
    /// <returns>The result matrix, having the specified row and column eliminated</returns>
    public static int[,] RemoveRowAndColumn(int[,] matrix, int rowIndex, int colIndex)
    {
      return MatrixHelper.RemoveColumn(MatrixHelper.RemoveRow(matrix, rowIndex), colIndex);
    }

    /// <summary>
    /// Calculates the determinant of a degeneratea 1 X 1 matrix
    /// </summary>
    /// <param name="matrix_1_x_1">The 1 X 1 matrix</param>
    /// <returns>The determinant of the 1 X 1 matrix</returns>
    private static int DeterminantMatrix1_1(int[,] matrix_1_x_1)
    {
      if (!MatrixHelper.IsMatrixValid(matrix_1_x_1))
      {
        return 0;
      }

      int rows = matrix_1_x_1.GetLength(0),
          cols = matrix_1_x_1.GetLength(1);

      if ((rows != cols) || (rows != 1))
      {
        return 0;
      }

      return matrix_1_x_1[0, 0];
    }

    /// <summary>
    /// Calculates the determinant of a 2 X 2 matrix
    /// </summary>
    /// <param name="matrix_2_x_2">The 2 X 2 matrix</param>
    /// <returns>The determinant of the 2 X 2 matrix</returns>
    private static int DeterminantMatrix2_2(int[,] matrix_2_x_2)
    {
      if (!MatrixHelper.IsMatrixValid(matrix_2_x_2))
      {
        return 0;
      }

      int rows = matrix_2_x_2.GetLength(0),
          cols = matrix_2_x_2.GetLength(1);

      if ((rows != cols) || (rows != 2))
      {
        return 0;
      }

      return matrix_2_x_2[0, 0] * matrix_2_x_2[1, 1] - matrix_2_x_2[0, 1] * matrix_2_x_2[1, 0];
    }

    /// <summary>
    /// Calculates the determinant of a square (n X n) matrix 
    /// using a recursive implementation of the Laplace expansion calculation method
    /// </summary>
    /// <param name="squareMatrix">The square (n X n) matrix</param>
    /// <returns>The determinant value</returns>
    public static int Determinant(int[,] squareMatrix)
    {
      // Uses Laplace expansion 
      // Inspiration came from: http://www.mathsisfun.com/algebra/matrix-determinant.html
      // See also: https://en.wikipedia.org/wiki/Laplace_expansion

      if (!MatrixHelper.IsMatrixValid(squareMatrix))
      {
        return 0;
      }

      int rows = squareMatrix.GetLength(0),
          cols = squareMatrix.GetLength(1);

      if (rows != cols)
      {
        Console.WriteLine("The matrix is not square");
        return 0;
      }

      if (rows == 1)
      {
        return MatrixHelper.DeterminantMatrix1_1(squareMatrix);
      }
      else if (rows == 2)
      {
        return MatrixHelper.DeterminantMatrix2_2(squareMatrix);
      }
      else
      {
        int det = 0;
        for (int i = 0; i < cols; i++)
        {
          int sign = (i % 2 == 0) ? 1 : (-1);

          det += sign * squareMatrix[0, i] * MatrixHelper.Determinant(MatrixHelper.RemoveRowAndColumn(squareMatrix, 0, i));
        }

        return det;
      }
    }

    /// <summary>
    /// Calculates and returns the transpose for the specified matrix
    /// </summary>
    /// <param name="matrix">The matrix</param>
    /// <returns>The transpose matrix</returns>
    public static int[,] Transpose(int[,] matrix)
    {
      if (!MatrixHelper.IsMatrixValid(matrix))
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

    /// <summary>
    /// Calculates and returns the adjunct for the specified matrix
    /// </summary>
    /// <param name="matrix">The matrix</param>
    /// <returns>The adjunct matrix</returns>
    public static int[,] Adjunct(int[,] matrix)
    {
      if (!MatrixHelper.IsMatrixValid(matrix))
      {
        return new int[0, 0];
      }

      int rows = matrix.GetLength(0),
          cols = matrix.GetLength(1);

      if (rows != cols)
      {
        Console.WriteLine("The matrix is not square");
        return new int[0, 0];
      }

      int[,] transpose = MatrixHelper.Transpose(matrix);

      if (!MatrixHelper.IsMatrixValid(transpose))
      {
        return new int[0, 0];
      }

      int rowsTranspose = transpose.GetLength(0),
          colsTranspose = transpose.GetLength(1);

      int[,] adjunct = new int[rowsTranspose, colsTranspose];

      for (int i = 0; i < rowsTranspose; i++)
      {
        for (int j = 0; j < colsTranspose; j++)
        {
          int sign = ((i + j) % 2 == 0) ? 1 : -1;

          int minor = MatrixHelper.Determinant(MatrixHelper.RemoveRowAndColumn(transpose, i, j));

          adjunct[i, j] = sign * minor;
        }
      }

      return adjunct;
    }

    /// <summary>
    /// Calculates and returns the inverse for the specified matrix
    /// </summary>
    /// <param name="squareMatrix">The square (n X n) matrix</param>
    /// <returns>The inverse matrix</returns>
    public static float[,] Invert(int[,] squareMatrix)
    {
      // Calculation method translated to algorithm
      // based on article here: http://mate123.ro/formule-matematice-algebra-liceu-generala/inversa-unei-matrici-de-ordin-3/

      if (!MatrixHelper.IsMatrixValid(squareMatrix))
      {
        return new float[0, 0];
      }

      int rows = squareMatrix.GetLength(0),
          cols = squareMatrix.GetLength(1);

      if (rows != cols)
      {
        Console.WriteLine("The matrix is not square");
        return new float[0, 0];
      }

      int determinant = MatrixHelper.Determinant(squareMatrix);
      if (determinant == 0)
      {
        Console.WriteLine("The determinant is 0, the matrix is not invertible!");
        return new float[0, 0];
      }

      int[,] adjunct = MatrixHelper.Adjunct(squareMatrix);

      if (!MatrixHelper.IsMatrixValid(adjunct))
      {
        return new float[0, 0];
      }

      int rowsAdjunct = adjunct.GetLength(0),
          colsAdjunct = adjunct.GetLength(1);

      float[,] inverted = new float[rowsAdjunct, colsAdjunct];

      for (int i = 0; i < rowsAdjunct; i++)
      {
        for (int j = 0; j < colsAdjunct; j++)
        {
          inverted[i, j] = (1 / (float)determinant) * adjunct[i, j];
        }
      }

      return inverted;
    }

    /// <summary>
    /// Calculates the sum of two matrixes and returns the result
    /// </summary>
    /// <param name="matrix1">The first matrix</param>
    /// <param name="matrix2">The second matrix</param>
    /// <returns>The result matrix (sum of the two)</returns>
    public static int[,] Add(int[,] matrix1, int[,] matrix2)
    {
      if ((!MatrixHelper.IsMatrixValid(matrix1)) || (!MatrixHelper.IsMatrixValid(matrix2)))
      {
        return new int[0, 0];
      }

      int rows1 = matrix1.GetLength(0),
          cols1 = matrix1.GetLength(1),
          // --------------------------
          rows2 = matrix2.GetLength(0),
          cols2 = matrix2.GetLength(1);

      if ((rows1 != rows2) || (cols1 != cols2))
      {
        Console.WriteLine($"The two matrixes must be of the same type (same number of rows, same number of columns). Actually, first matrix is {rows1}x{cols1} and second matrix is {rows2}x{cols2}");
        return new int[0, 0];
      }

      int[,] result = new int[rows1, cols1];
      for (int i = 0; i < rows1; i++)
      {
        for (int j = 0; j < cols1; j++)
        {
          result[i, j] = matrix1[i, j] + matrix2[i, j];
        }
      }

      return result;
    }

    /// <summary>
    /// Calculates the difference of two matrixes and returns the results
    /// </summary>
    /// <param name="matrix1">The first matrix</param>
    /// <param name="matrix2">The second matrix</param>
    /// <returns>The result matrix (difference of the two)</returns>
    public static int[,] Substract(int[,] matrix1, int[,] matrix2)
    {
      if ((!MatrixHelper.IsMatrixValid(matrix1)) || (!MatrixHelper.IsMatrixValid(matrix2)))
      {
        return new int[0, 0];
      }

      int rows1 = matrix1.GetLength(0),
          cols1 = matrix1.GetLength(1),
          // --------------------------
          rows2 = matrix2.GetLength(0),
          cols2 = matrix2.GetLength(1);

      if ((rows1 != rows2) || (cols1 != cols2))
      {
        Console.WriteLine($"The two matrixes must be of the same type (same number of rows, same number of columns). Actually, first matrix is {rows1}x{cols1} and second matrix is {rows2}x{cols2}");
        return new int[0, 0];
      }

      int[,] result = new int[rows1, cols1];
      for (int i = 0; i < rows1; i++)
      {
        for (int j = 0; j < cols1; j++)
        {
          result[i, j] = matrix1[i, j] - matrix2[i, j];
        }
      }

      return result;
    }

    /// <summary>
    /// Calculates the product of two matrixes and returns the result
    /// </summary>
    /// <param name="matrix1">The first matrix</param>
    /// <param name="matrix2">The second matrix</param>
    /// <returns>The result matrix (product of the two)</returns>
    public static int[,] Multiply(int[,] matrix1, int[,] matrix2)
    {
      if ((!MatrixHelper.IsMatrixValid(matrix1)) || (!MatrixHelper.IsMatrixValid(matrix2)))
      {
        return new int[0, 0];
      }

      int rows1 = matrix1.GetLength(0),
          cols1 = matrix1.GetLength(1),
          // --------------------------
          rows2 = matrix2.GetLength(0),
          cols2 = matrix2.GetLength(1);

      if (cols1 != rows2)
      {
        Console.WriteLine($"Matrix 1 columns number should equal matrix 2 rows number. Actually, first matrix is {rows1}x{cols1} and second matrix is {rows2}x{cols2}");
        return new int[0, 0];
      }

      int[,] result = new int[rows1, cols2];
      for (int i = 0; i < rows1; i++)
      {
        for (int j = 0; j < cols2; j++)
        {
          // iterate Matrix1.Line(i) over columns
          // iterate Matrix2.Col(j) over rows
          // in one "for" loop, because, Matrix1.Cols = Matrix2.Rows
          // and make product and sum elements

          int sum = 0;
          for (int k = 0; k < cols1; k++)
          {
            sum += matrix1[i, k] * matrix2[k, j];
          }

          result[i, j] = sum;
        }
      }

      return result;
    }
  }
}
