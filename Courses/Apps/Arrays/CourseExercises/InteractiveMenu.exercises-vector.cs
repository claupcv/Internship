using CourseExercises.Classes;
using System;

namespace CourseExercises
{
  public partial class InteractiveMenu
  {
    private void Vectors_ReadFromConsole()
    {
      Console.Clear();

      ConsoleHelper.WriteSeparator("Read a vector");

      this.vector = VectorHelper.ReadFromConsole();

      this.Vectors_PrintToConsole(false);
    }

    private void Vectors_PrintToConsole(bool clear)
    {
      if (clear)
      {
        Console.Clear();
      }

      ConsoleHelper.WriteSeparator("The read vector is ");

      VectorHelper.PrintToConsole(this.vector);

      this.ExerciseEnd_PromptGoBackToMenu("vectors");
    }

    private void Vectors_SumWithAnother()
    {
      Console.Clear();

      ConsoleHelper.WriteSeparator("Read the other vector");

      int[] other = VectorHelper.ReadFromConsole();

      Console.Clear();

      ConsoleHelper.WriteSeparator("First vector is ");

      VectorHelper.PrintToConsole(this.vector);

      ConsoleHelper.WriteSeparator("Second vector is ");

      VectorHelper.PrintToConsole(other);

      int[] sum = VectorHelper.Add(this.vector, other);

      ConsoleHelper.WriteSeparator("The sum (vector1 + vector2) is ");

      VectorHelper.PrintToConsole(sum);

      this.ExerciseEnd_PromptGoBackToMenu("vectors");
    }

    private void Vectors_DiffWithAnother()
    {
      Console.Clear();

      ConsoleHelper.WriteSeparator("Read the other vector");

      int[] other = VectorHelper.ReadFromConsole();

      Console.Clear();

      ConsoleHelper.WriteSeparator("First vector is ");

      VectorHelper.PrintToConsole(this.vector);

      ConsoleHelper.WriteSeparator("Second vector is ");

      VectorHelper.PrintToConsole(other);

      int[] diff = VectorHelper.Substract(this.vector, other);

      ConsoleHelper.WriteSeparator("The difference (vector1 - vector2) is ");

      VectorHelper.PrintToConsole(diff);

      this.ExerciseEnd_PromptGoBackToMenu("vectors");
    }

    private void Vectors_SortAscending()
    {
      Console.Clear();

      ConsoleHelper.WriteSeparator("The read vector is ");

      VectorHelper.PrintToConsole(this.vector);

      ConsoleHelper.WriteSeparator("The vector sorted ascending is ");

      int[] sorted = VectorHelper.SortAscending(this.vector);

      VectorHelper.PrintToConsole(sorted);

      this.ExerciseEnd_PromptGoBackToMenu("vectors");
    }

    private void Vectors_SortDescending()
    {
      Console.Clear();

      ConsoleHelper.WriteSeparator("The read vector is ");

      VectorHelper.PrintToConsole(this.vector);

      ConsoleHelper.WriteSeparator("The vector sorted descending is ");

      int[] sorted = VectorHelper.SortDescending(this.vector);

      VectorHelper.PrintToConsole(sorted);

      this.ExerciseEnd_PromptGoBackToMenu("vectors");
    }

    private void Vectors_SeekAndPrintElement()
    {
      Console.Clear();

      ConsoleHelper.WriteSeparator("Seek an element in a vector and print search results");

      int elementToSeek = ConsoleHelper.ReadIntegerFromConsole("Element to seek: ", 0, 10);

      Console.Clear();

      ConsoleHelper.WriteSeparator("The vector is");

      VectorHelper.PrintToConsole(this.vector);

      VectorHelper.FindElementAndPrintResults(this.vector, elementToSeek);

      this.ExerciseEnd_PromptGoBackToMenu("vectors");
    }

    private void Vectors_PrintEven()
    {
      Console.Clear();

      ConsoleHelper.WriteSeparator("The read vector is ");

      VectorHelper.PrintToConsole(this.vector);

      ConsoleHelper.WriteSeparator("The even elements are ");

      VectorHelper.PrintEvenElements(this.vector);

      this.ExerciseEnd_PromptGoBackToMenu("vectors");
    }

    private void Vectors_PrintOdd()
    {
      Console.Clear();

      ConsoleHelper.WriteSeparator("The read vector is ");

      VectorHelper.PrintToConsole(this.vector);

      ConsoleHelper.WriteSeparator("The odd elements are ");

      VectorHelper.PrintOddElements(this.vector);

      this.ExerciseEnd_PromptGoBackToMenu("vectors");
    }

    private void Vectors_Reverse()
    {
      Console.Clear();

      ConsoleHelper.WriteSeparator("The read vector is ");

      VectorHelper.PrintToConsole(this.vector);

      ConsoleHelper.WriteSeparator("The reversed vector is");

      int[] reversed = VectorHelper.Reverse(this.vector);

      VectorHelper.PrintToConsole(reversed);

      this.ExerciseEnd_PromptGoBackToMenu("vectors");
    }
  }
}
