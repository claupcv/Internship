namespace LoggingLibrary.Abstractions
{
  public abstract class LoggerFactory
  {
    public abstract LoggerType LoggerType
    {
      get;
    }

    public abstract Logger CreateLogger();
  }
}
