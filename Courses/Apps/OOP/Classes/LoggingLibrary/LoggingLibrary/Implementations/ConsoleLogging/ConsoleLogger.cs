using LoggingLibrary.Abstractions;
using System;

namespace LoggingLibrary.Implementations.ConsoleLogging
{
  public class ConsoleLogger : Logger
  {
    public override void Write(LogLevel level, Exception e)
    {
      var serializer = new ConsoleExceptionStringSerializer(level, e, DateTime.Now);

      var exceptionText = serializer.GetExceptionString();

      System.Console.WriteLine(exceptionText);
    }
  }
}
