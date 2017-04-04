namespace ProcessLibrary
{
  /// <summary>
  /// Holds numeric values representing various process execution error codes
  /// </summary>
  public class ProcessingErrorCodes
  {
    /// <summary>
    /// Represents the "error" code for succefull process execution.
    /// Even if the name of the class is "error codes", we need also a value which represents success.
    /// </summary>
    public const int Success = 0;

    /// <summary>
    /// Represents an unknown / undetermined error
    /// </summary>
    public const int UnspecifiedError = 1;
  }
}
