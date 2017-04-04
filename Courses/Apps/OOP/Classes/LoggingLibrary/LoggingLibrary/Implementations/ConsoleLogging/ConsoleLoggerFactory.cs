using LoggingLibrary.Abstractions;

namespace LoggingLibrary.Implementations.ConsoleLogging
{
  public class ConsoleLoggerFactory : LoggerFactory
  {
    public override LoggerType LoggerType
    {
      get
      {
        return LoggerType.ConsoleWindow;
      }
    }

    public override Logger CreateLogger()
    {
      return new ConsoleLogger();
    }
  }
}
