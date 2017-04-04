using LoggingLibrary.Helpers;
using System;
using System.Text;

namespace LoggingLibrary.Implementations.ConsoleLogging
{
  /// <summary>
  /// Custom exception serializer adapted for writing to console
  /// </summary>
  public class ConsoleExceptionStringSerializer : ExceptionStringSerializer
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="ConsoleExceptionStringSerializer"/> class
    /// </summary>
    /// <param name="level">The log level</param>
    /// <param name="e">The exception</param>
    /// <param name="timestamp">The exception timestamp</param>
    public ConsoleExceptionStringSerializer(LogLevel level, Exception e, DateTime timestamp)
      : base(level, e, timestamp)
    {
    }

    /// <summary>
    /// Overrides the serialization start to write a full-line separator, according to console's window width
    /// </summary>
    /// <param name="sb">The string builder used for serialization</param>
    protected override void SerializeStart(StringBuilder sb)
    {
      var separator = new string('-', Console.WindowWidth - 1);

      sb.AppendLine(separator);
    }

    /// <summary>
    /// Overrides the serialization end to write a full-line separator, according to console's window width
    /// </summary>
    /// <param name="sb">The string builder used for serialization</param>
    protected override void SerializeEnd(StringBuilder sb)
    {
      var separator = new string('-', Console.WindowWidth - 1);

      sb.AppendLine(separator);
    }
  }
}
