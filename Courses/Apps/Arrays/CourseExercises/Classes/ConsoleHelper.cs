using System;

namespace CourseExercises.Classes
{
  /// <summary>
  /// Helper class used when working with console
  /// </summary>
  public static class ConsoleHelper
  {
    /// <summary>
    /// Reads an integer from the console.
    /// If user inputs a value that doesn't represent an integer value, the method will retry to read.
    /// If retries count exceed the max attempts count, then the default value will be used.
    /// Also, if user chooses to forcibly close (typing "quit" or "exit") the default value will be returned.
    /// </summary>
    /// <param name="label">The label to present to the user (describes the value to be read)</param>
    /// <param name="defaultValue">The default value to use when max attempts count is exceeded, or when user abandons editing</param>
    /// <param name="maxRetryAttemptsCount">The maximum number of retry attempts</param>
    /// <returns></returns>
    public static int ReadIntegerFromConsole(string label, int defaultValue, int maxRetryAttemptsCount)
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
        if (attemptsCount > maxRetryAttemptsCount)
        {
          Console.WriteLine($"Exceeded read max attempts count ({maxRetryAttemptsCount}), assuming default value ({defaultValue})");
          break;
        }
      }
      while (!inputOk);

      return value;
    }

    /// <summary>
    /// Writes a separator ("-") ocuppying a full screen line
    /// </summary>
    public static void WriteSeparator()
    {
      ConsoleHelper.WriteSeparator("");
    }

    /// <summary>
    /// Writes a separator with a label (label will be framed by separators).
    /// Used to create a nice "heading".
    /// </summary>
    /// <param name="label">The label to display.</param>
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

    /// <summary>
    /// Writes a value padded with spaces, so it will always occupy a fixed width.
    /// </summary>
    /// <param name="value">The value to write</param>
    /// <param name="fixedWidth">The fixed width (measured in number of characters)</param>
    public static void WriteValueFixedWidth(int value, int fixedWidth)
    {
      if (fixedWidth <= 0)
      {
        Console.Write(value);
        return;
      }

      // pad one space before to fit "-" sign for negative numbers
      int spacesBeforeCount = (value > 0) ? 1 : 0;

      // pad spaces after to respect fixed with
      string valueAsString = value.ToString().TrimEnd();
      int spacesAfterCount = fixedWidth - valueAsString.Length - spacesBeforeCount;
      if (spacesAfterCount <= 0)
      {
        spacesAfterCount = 0;
      }

      string spacesBefore = new string(' ', spacesBeforeCount);

      string spacesAfter = new string(' ', spacesAfterCount);

      Console.Write($"{spacesBefore}{valueAsString}{spacesAfter}");
    }

    /// <summary>
    /// Writes a value padded with spaces, so it will always occupy a fixed width.
    /// </summary>
    /// <param name="value">The value to write</param>
    /// <param name="fixedWidth">The fixed width (measured in number of characters)</param>
    public static void WriteValueFixedWidth(float value, int fixedWidth)
    {
      if (fixedWidth <= 0)
      {
        Console.Write(value);
        return;
      }

      // pad one space before to fit "-" sign for negative numbers
      int spacesBeforeCount = (value > 0) ? 1 : 0;

      // pad spaces after to respect fixed with
      string valueAsString = value.ToString("0.00").TrimEnd();
      int spacesAfterCount = fixedWidth - valueAsString.Length - spacesBeforeCount;
      if (spacesAfterCount <= 0)
      {
        spacesAfterCount = 0;
      }

      string spacesBefore = new string(' ', spacesBeforeCount);

      string spacesAfter = new string(' ', spacesAfterCount);

      Console.Write($"{spacesBefore}{valueAsString}{spacesAfter}");
    }

    /// <summary>
    /// Creates a console menu, having the specified options
    /// </summary>
    /// <param name="title">The menu title</param>
    /// <param name="options">The menu options</param>
    public static void WriteMenuWithOptions(string title, string[] options)
    {
      ConsoleHelper.WriteSeparator(title);

      if ((options == null) || (options.Length == 0))
      {
        return;
      }

      int spacesBeforeCount = (options.Length >= 10) ? 1 : 0;
      string spacesBefore = new string(' ', spacesBeforeCount);

      for (int i = 0; i < options.Length; i++)
      {
        Console.WriteLine($"{spacesBefore}{i + 1}) {options[i]}");
      }

      ConsoleHelper.WriteSeparator();
    }

    /// <summary>
    /// Creates a console menu, deciding based on a condition which options set to use
    /// </summary>
    /// <param name="title">The menu title</param>
    /// <param name="condition">The condition to evaluate</param>
    /// <param name="optionsSetTrue">The options to use when the condition evaluates to true</param>
    /// <param name="optionSetFalse">The options to use when the condition evaluates to false</param>
    public static void WriteMenuWithOptionsConditional(string title, bool condition, string[] optionsSetTrue, string[] optionSetFalse)
    {
      string[] options = condition ? optionsSetTrue : optionSetFalse;

      ConsoleHelper.WriteMenuWithOptions(title, options);
    }
  }
}
