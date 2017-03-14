using System;

namespace CourseExercises.Classes
{
  public static class VectorHelper
  {
    private static bool ValidateVector(int[] vector)
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

    public static void FindElement(int[] vector, int element)
    {
      if (!VectorHelper.ValidateVector(vector))
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

    public static void PrintOddElements(int[] vector)
    {
      if (!VectorHelper.ValidateVector(vector))
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

    public static void PrintEvenElements(int[] vector)
    {
      if (!VectorHelper.ValidateVector(vector))
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

    public static int[] Reverse(int[] vector)
    {
      if (!VectorHelper.ValidateVector(vector))
      {
        return new int[0];
      }

      int[] result = new int[vector.Length];

      for (int i = 0; i < result.Length; i++)
      {
        result[i] = vector[vector.Length - i - 1];
      }

      return result;
    }
  }
}
