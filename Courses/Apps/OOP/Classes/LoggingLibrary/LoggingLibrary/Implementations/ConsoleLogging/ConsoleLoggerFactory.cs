using LoggingLibrary.Abstractions;

namespace LoggingLibrary.Implementations.ConsoleLogging
{
  /// <summary>
  /// Concrete logger factory, creates console window loggers
  /// </summary>
  public class ConsoleLoggerFactory : LoggerFactory
  {
    /// <summary>
    /// Gets the logger type that this factory creates (console window loggers)
    /// </summary>
    public override LoggerType LoggerType
    {
      get
      {
        return LoggerType.ConsoleWindow;
      }
    }

    /// <summary>
    /// Creates a new logger instance (console logger)
    /// </summary>
    /// <returns>The logger instance</returns>
    public override Logger CreateLogger()
    {
      return new ConsoleLogger();
    }
  }
}
