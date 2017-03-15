using CourseExercises.Classes;
using System;

namespace CourseExercises
{
  public partial class InteractiveMenu
  {
    private void ExerciseEnd_PromptGoBackToMenu(string menuName)
    {
      ConsoleHelper.WriteSeparator();

      Console.WriteLine($"Press any key to return back to {menuName} menu ...");

      Console.ReadKey();
    }
  }
}
