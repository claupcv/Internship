namespace LoggingLibrary
{
  /// <summary>
  /// Enumerates all the supported logger types
  /// </summary>
  public enum LoggerType
  {
    /// <summary>
    /// Unspecified logger type
    /// </summary>
    Unspecified = 0,

    /// <summary>
    /// Console window logger
    /// </summary>
    ConsoleWindow,

    /// <summary>
    /// Debug window logger
    /// </summary>
    DebugWindow,

    /// <summary>
    /// Windows Event Viewer logger
    /// </summary>
    WindowsEventViewer
  }
}
