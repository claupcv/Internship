using LoggingLibrary.Abstractions;
using LoggingLibrary.Helpers;
using System;
using System.Diagnostics;

namespace LoggingLibrary.Implementations.DebugWindowLogging
{
  public class DebugWindowLogger : Logger
  {
    public override void Write(LogLevel level, Exception e)
    {
      var exceptionSerializer = new ExceptionStringSerializer(level, e, DateTime.Now);

      var exceptionText = exceptionSerializer.GetExceptionString();

      Debug.WriteLine(exceptionText);
    }
  }
}
