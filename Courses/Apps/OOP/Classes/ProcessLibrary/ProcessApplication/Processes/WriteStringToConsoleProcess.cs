using ProcessLibrary;
using System;

namespace ProcessApplication.Processes
{
  /// <summary>
  /// Represents the process which writes a string (text) to console
  /// </summary>
  public class WriteStringToConsoleProcess : Process
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="WriteStringToConsoleProcess"/> class
    /// </summary>
    /// <param name="text"></param>
    public WriteStringToConsoleProcess(string text)
    {
      this.Text = text;
    }

    /// <summary>
    /// Gets the process identifier
    /// </summary>
    public override int PID
    {
      get
      {
        return (int)ProcessIds.WriteStringToConsole;
      }
    }

    /// <summary>
    /// Gets the text to write to console
    /// </summary>
    public string Text
    {
      get;
      private set;
    }

    /// <summary>
    /// Validates the text to be written
    /// </summary>
    /// <returns>The process validation result</returns>
    protected override ProcessResult Validate()
    {
      if (this.Text == null)
      {
        return ProcessResult.Fail(ApplicationErrorCodes.WriteStringToConsole.TextIsNull);
      }

      if (string.Equals(this.Text, string.Empty))
      {
        return ProcessResult.Fail(ApplicationErrorCodes.WriteStringToConsole.TextIsEmpty);
      }

      if (string.IsNullOrWhiteSpace(this.Text))
      {
        return ProcessResult.Fail(ApplicationErrorCodes.WriteStringToConsole.TextIsWhitespacesOnly);
      }

      return ProcessResult.Success();
    }

    /// <summary>
    /// On processing phase, the process effectively writes the text to console
    /// </summary>
    /// <returns>The processing result</returns>
    protected override ProcessResult OnProcessing()
    {
      Console.WriteLine(this.Text);

      return ProcessResult.Success();
    }
  }
}
