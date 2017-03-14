using System;

namespace CourseExercises.Classes
{
  public static class ConsoleHelper
  {
    public static int ReadIntegerFromConsole(string label, int defaultValue, int maxAttempts)
    {
      int value = defaultValue;
      int attemptsCount = 0;
      bool inputOk = false;

      do
      {
        Console.Write(label);
        string input = Console.ReadLine();

        if (string.Equals(input, "quit", StringComparison.OrdinalIgnoreCase) ||
           string.Equals(input, "exit", StringComparison.OrdinalIgnoreCase))
        {
          break;
        }

        if (int.TryParse(input, out value))
        {
          inputOk = true;
          break;
        }
        else
        {
          Console.WriteLine($"'{input}' is not a valid numeric value, please try again!");
        }

        attemptsCount++;
        if (attemptsCount > maxAttempts)
        {
          Console.WriteLine($"Exceeded read max attempts count ({maxAttempts}), assuming default value ({defaultValue})");
          break;
        }
      }
      while (!inputOk);

      return value;
    }

    public static void WriteSeparator()
    {
      ConsoleHelper.WriteSeparator("");
    }

    public static void WriteSeparator(string label)
    {
      string separator = new string('-', Console.WindowWidth - 1);

      Console.WriteLine(separator);

      if (!string.IsNullOrWhiteSpace(label))
      {
        int spacesCount = (Console.WindowWidth - label.Length) / 2 - 1;
        Console.Write(new string(' ', spacesCount));
        Console.Write(label);
        Console.Write(new string(' ', spacesCount));

        Console.WriteLine();
        Console.Write(separator);
        Console.WriteLine();
      }
    }

    public static void WriteValueFixedWidth(int value, int totalWidth)
    {
      if(totalWidth <= 0)
      {
        Console.Write(value);
        return;
      }

      int spacesCount = totalWidth - value.ToString().Length;
      if (spacesCount <= 0)
      {
        Console.Write(value);
        return;
      }

      string spaces = new string(' ', spacesCount);

      Console.Write($"{value}{spaces}");
    }
  }
}
