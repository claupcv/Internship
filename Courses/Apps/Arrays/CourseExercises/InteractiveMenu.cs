namespace CourseExercises
{
  /// <summary>
  /// Represents the interactive menu
  /// </summary>
  public partial class InteractiveMenu
  {
    private int[] vector = null;

    private int[,] generalMatrix = null;

    private int[,] squareMatrix = null;

    /// <summary>
    /// Runs the interactive menu displaying options to user and managing user's response
    /// </summary>
    public void Run()
    {
      this.PromptMainMenu();

      this.ReadAndHandleMainMenuOption();
    }
  }
}
