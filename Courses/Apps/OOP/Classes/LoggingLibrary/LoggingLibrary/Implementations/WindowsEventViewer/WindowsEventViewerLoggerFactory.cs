using LoggingLibrary.Abstractions;

namespace LoggingLibrary.Implementations.WindowsEventViewer
{
  /// <summary>
  /// Concrete logger factory, creates Windows Event Viewer loggers
  /// </summary>
  public class WindowsEventViewerLoggerFactory : LoggerFactory
  {
    /// <summary>
    /// Gets the logger type that this factory creates (Windows Event Viewer loggers)
    /// </summary>
    public override LoggerType LoggerType
    {
      get
      {
        return LoggerType.WindowsEventViewer;
      }
    }

    /// <summary>
    /// Creates a new logger instance (Windows Event Viewer logger)
    /// </summary>
    /// <returns>The logger instance</returns>
    public override Logger CreateLogger()
    {
      return new WindowsEventViewerLogger();
    }
  }
}
