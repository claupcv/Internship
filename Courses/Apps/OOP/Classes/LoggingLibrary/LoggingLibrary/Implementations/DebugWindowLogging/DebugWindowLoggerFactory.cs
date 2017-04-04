using System;
using LoggingLibrary.Abstractions;

namespace LoggingLibrary.Implementations.DebugWindowLogging
{
  public class DebugWindowLoggerFactory : LoggerFactory
  {
    public override LoggerType LoggerType
    {
      get
      {
        return LoggerType.DebugWindow;
      }
    }

    public override Logger CreateLogger()
    {
      return new DebugWindowLogger();
    }
  }
}
