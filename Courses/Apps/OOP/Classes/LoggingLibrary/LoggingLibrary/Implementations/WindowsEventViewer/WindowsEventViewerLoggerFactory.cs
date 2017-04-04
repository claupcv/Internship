using LoggingLibrary.Abstractions;

namespace LoggingLibrary.Implementations.WindowsEventViewer
{
  public class WindowsEventViewerLoggerFactory : LoggerFactory
  {
    public override LoggerType LoggerType
    {
      get
      {
        return LoggerType.WindowsEventViewer;
      }
    }

    public override Logger CreateLogger()
    {
      return new WindowsEventViewerLogger();
    }
  }
}
