using LoggingLibrary.Abstractions;

namespace LoggingLibrary.Implementations.DebugWindowLogging
{
  /// <summary>
  /// Concrete logger factory, creates VS debug window loggers
  /// </summary>
  public class DebugWindowLoggerFactory : LoggerFactory
  {
    /// <summary>
    /// Gets the logger type that this factory creates (VS debug window loggers)
    /// </summary>
    public override LoggerType LoggerType
    {
      get
      {
        return LoggerType.DebugWindow;
      }
    }

    /// <summary>
    /// Creates a new logger instance (VS debug window logger)
    /// </summary>
    /// <returns>The logger instance</returns>
    public override Logger CreateLogger()
    {
      return new DebugWindowLogger();
    }
  }
}
