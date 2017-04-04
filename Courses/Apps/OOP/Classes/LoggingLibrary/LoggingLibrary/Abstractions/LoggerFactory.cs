namespace LoggingLibrary.Abstractions
{
  /// <summary>
  /// Abstracts a logger factory
  /// </summary>
  public abstract class LoggerFactory
  {
    /// <summary>
    /// Gets the logger type that this factory creates
    /// </summary>
    public abstract LoggerType LoggerType
    {
      get;
    }

    /// <summary>
    /// Creates a new logger instance
    /// </summary>
    /// <returns>The logger instance</returns>
    public abstract Logger CreateLogger();
  }
}
