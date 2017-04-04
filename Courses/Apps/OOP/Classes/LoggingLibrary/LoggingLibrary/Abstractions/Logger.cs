using System;

namespace LoggingLibrary.Abstractions
{
  /// <summary>
  /// Abstracts a logger
  /// </summary>
  public abstract class Logger
  {
    /// <summary>
    /// Writes a log entry
    /// </summary>
    /// <param name="level">The logging level</param>
    /// <param name="e">The exception to be logged</param>
    public abstract void Write(LogLevel level, Exception e);
  }
}
