using System;

namespace CourseExercises.Classes
{
  /// <summary>
  /// Helper class used when working with vectors
  /// </summary>
  public static class VectorHelper
  {
    /// <summary>
    /// Returns a boolean value indicating whether the vector is valid (is not null, and has a valid length)
    /// </summary>
    /// <param name="vector"></param>
    /// <returns></returns>
    private static bool IsVectorValid(int[] vector)
    {
      if (vector == null)
      {
        Console.WriteLine("The vector is null");
        return false;
      }

      if (vector.Length == 0)
      {
        Console.WriteLine("The vector has 0 elements");
        return false;
      }

      return true;
    }

    /// <summary>
    /// Reads a vector from console
    /// </summary>
    /// <returns>The vector filled with elements</returns>
    public static int[] ReadFromConsole()
    {
      int n = ConsoleHelper.ReadIntegerFromConsole("No. of elements: ", 0, 10);
      if (n < 0)
      {
        n = 0;
      }

      var array = new int[n];
      for (int i = 0; i < n; i++)
      {
        int element = ConsoleHelper.ReadIntegerFromConsole($"Element at index {i}: ", 0, 10);

        array[i] = element;
      }

      return array;
    }

    /// <summary>
    /// Prints a vector to console
    /// </summary>
    /// <param name="vector">The vector to pring</param>
    public static void PrintToConsole(int[] vector)
    {
      if (vector == null)
      {
        Console.WriteLine("The vector is null");
      }

      if (vector.Length == 0)
      {
        Console.WriteLine("The vector has 0 elements");
      }

      for (int i = 0; i < vector.Length; i++)
      {
        int value = vector[i];
        Console.WriteLine($"vector[{i}]={value}");
      }
    }

    /// <summary>
    /// Locates an element in a vector and prints the search result
    /// </summary>
    /// <param name="vector">The vector</param>
    /// <param name="element">The element to find</param>
    public static void FindElementAndPrintResults(int[] vector, int element)
    {
      if (!VectorHelper.IsVectorValid(vector))
      {
        return;
      }

      bool found = false;
      for (int i = 0; i < vector.Length; i++)
      {
        int value = vector[i];
        if (value == element)
        {
          Console.WriteLine($"Element {element} found at index {i}");
          found = true;
          break;
        }
      }

      if (!found)
      {
        Console.WriteLine($"Element {element} was not found!");
      }
    }

    /// <summary>
    /// Prints all the odd elements from a vector
    /// </summary>
    /// <param name="vector">The vector</param>
    public static void PrintOddElements(int[] vector)
    {
      if (!VectorHelper.IsVectorValid(vector))
      {
        return;
      }

      Console.Write("Odd elements: ");
      foreach (int element in vector)
      {
        if (element % 2 != 0)
        {
          Console.Write($"{element}, ");
        }
      }

      Console.WriteLine();
    }

    /// <summary>
    /// Prints all the even elements from a vector
    /// </summary>
    /// <param name="vector">The vector</param>
    public static void PrintEvenElements(int[] vector)
    {
      if (!VectorHelper.IsVectorValid(vector))
      {
        return;
      }

      Console.Write("Even elements: ");
      foreach (int element in vector)
      {
        if (element % 2 == 0)
        {
          Console.Write($"{element}, ");
        }
      }

      Console.WriteLine();
    }

    /// <summary>
    /// Returns the reversed vector
    /// </summary>
    /// <param name="vector">The vector</param>
    /// <returns></returns>
    public static int[] Reverse(int[] vector)
    {
      if (!VectorHelper.IsVectorValid(vector))
      {
        return new int[0];
      }

      // we could reverse the elements
      // using the "vector" argument
      // (that would be more performant because it wouldn't imply a new allocation)
      // but because of the way we want to use this library
      // we would rather do it this way, preventing changes in the argument
      int[] result = new int[vector.Length];

      for (int i = 0; i < result.Length; i++)
      {
        result[i] = vector[vector.Length - i - 1];
      }

      return result;
    }

    /// <summary>
    /// Calculates the sum of two vectors and returns the result
    /// </summary>
    /// <param name="vector1">The first vector</param>
    /// <param name="vector2">The second vector</param>
    /// <returns>The sum of the two vectors</returns>
    public static int[] Add(int[] vector1, int[] vector2)
    {
      if ((!VectorHelper.IsVectorValid(vector1)) || (!VectorHelper.IsVectorValid(vector2)))
      {
        return new int[0];
      }

      if (vector1.Length != vector2.Length)
      {
        Console.WriteLine($"The two vectors must have the same length, actually vector 1 has {vector1.Length} elements, while vector 2 has {vector2.Length} elements");
        return new int[0];
      }

      int[] result = new int[vector1.Length];

      for (int i = 0; i < result.Length; i++)
      {
        result[i] = vector1[i] + vector2[i];
      }

      return result;
    }

    /// <summary>
    /// Calculates the difference of two vectors and returns the result
    /// </summary>
    /// <param name="vector1">The first vector</param>
    /// <param name="vector2">The second vector</param>
    /// <returns>The difference of the two vectors</returns>
    public static int[] Substract(int[] vector1, int[] vector2)
    {
      if ((!VectorHelper.IsVectorValid(vector1)) || (!VectorHelper.IsVectorValid(vector2)))
      {
        return new int[0];
      }

      if (vector1.Length != vector2.Length)
      {
        Console.WriteLine($"The two vectors must have the same length, actually vector 1 has {vector1.Length} elements, while vector 2 has {vector2.Length} elements");
        return new int[0];
      }

      int[] result = new int[vector1.Length];

      for (int i = 0; i < result.Length; i++)
      {
        result[i] = vector1[i] - vector2[i];
      }

      return result;
    }

    /// <summary>
    /// Clones a vector
    /// </summary>
    /// <param name="vector">The vector</param>
    /// <returns>A new vector having the same size and elements</returns>
    public static int[] Clone(int[] vector)
    {
      if (!VectorHelper.IsVectorValid(vector))
      {
        return new int[0];
      }

      int[] result = new int[vector.Length];
      for (int i = 0; i < result.Length; i++)
      {
        result[i] = vector[i];
      }

      return result;
    }

    /// <summary>
    /// Returns the vector having the elements sorted in an ascending order
    /// </summary>
    /// <param name="vector">The vector</param>
    /// <returns>A vector having its elements sorted in an ascending order</returns>
    public static int[] SortAscending(int[] vector)
    {
      if (!VectorHelper.IsVectorValid(vector))
      {
        return new int[0];
      }

      // we could sort the elements
      // using the "vector" argument
      // (that would be more performant because it wouldn't imply a new allocation)
      // but because of the way we want to use this library
      // we would rather do it this way, preventing changes in the argument
      int[] result = VectorHelper.Clone(vector);

      for (int i = 0; i < result.Length; i++)
      {
        for (int j = i + 1; j < result.Length; j++)
        {
          if (result[i] > result[j])
          {
            int temp = result[i];
            result[i] = result[j];
            result[j] = temp;
          }
        }
      }

      return result;
    }

    /// <summary>
    /// Returns the vector having the elements sorted in an descending order
    /// </summary>
    /// <param name="vector">The vector</param>
    /// <returns>A vector having its elements sorted in an descending order</returns>
    public static int[] SortDescending(int[] vector)
    {
      if (!VectorHelper.IsVectorValid(vector))
      {
        return new int[0];
      }

      // we could sort the elements
      // using the "vector" argument
      // (that would be more performant because it wouldn't imply a new allocation)
      // but because of the way we want to use this library
      // we would rather do it this way, preventing changes in the argument
      int[] result = VectorHelper.Clone(vector);

      for (int i = 0; i < result.Length; i++)
      {
        for (int j = i + 1; j < result.Length; j++)
        {
          if (result[i] < result[j])
          {
            int temp = result[i];
            result[i] = result[j];
            result[j] = temp;
          }
        }
      }

      return result;
    }
  }
}
