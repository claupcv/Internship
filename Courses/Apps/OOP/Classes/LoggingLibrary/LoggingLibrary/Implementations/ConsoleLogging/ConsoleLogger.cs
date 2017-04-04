using LoggingLibrary.Abstractions;
using System;

namespace LoggingLibrary.Implementations.ConsoleLogging
{
  /// <summary>
  /// Concrete logger, which writes exceptions to console window
  /// </summary>
  public class ConsoleLogger : Logger
  {
    /// <summary>
    /// Writes an exception to the console window
    /// </summary>
    /// <param name="level">The log level</param>
    /// <param name="e">The exception</param>
    public override void Write(LogLevel level, Exception e)
    {
      var serializer = new ConsoleExceptionStringSerializer(level, e, DateTime.Now);

      var exceptionText = serializer.GetExceptionString();

      System.Console.WriteLine(exceptionText);
    }
  }
}
