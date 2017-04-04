using LoggingLibrary.Helpers;
using System;
using System.Text;

namespace LoggingLibrary.Implementations.ConsoleLogging
{
  public class ConsoleExceptionStringSerializer : ExceptionStringSerializer
  {
    public ConsoleExceptionStringSerializer(LogLevel level, Exception e, DateTime timestamp)
      : base(level, e, timestamp)
    {
    }

    protected override void SerializeStart(StringBuilder sb)
    {
      var separator = new string('-', Console.WindowWidth - 1);

      sb.AppendLine(separator);
    }

    protected override void SerializeEnd(StringBuilder sb)
    {
      var separator = new string('-', Console.WindowWidth - 1);

      sb.AppendLine(separator);
    }
  }
}
