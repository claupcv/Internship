using LoggingLibrary.Abstractions;
using LoggingLibrary.Helpers;
using System;
using System.Diagnostics;

namespace LoggingLibrary.Implementations.DebugWindowLogging
{
  /// <summary>
  /// Concrete logger, which writes exceptions to VS debug window
  /// </summary>
  public class DebugWindowLogger : Logger
  {
    /// <summary>
    /// Writes an exception to the VS debug window
    /// </summary>
    /// <param name="level">The log level</param>
    /// <param name="e">The exception</param>
    public override void Write(LogLevel level, Exception e)
    {
      var exceptionSerializer = new ExceptionStringSerializer(level, e, DateTime.Now);

      var exceptionText = exceptionSerializer.GetExceptionString();

      Debug.WriteLine(exceptionText);
    }
  }
}
