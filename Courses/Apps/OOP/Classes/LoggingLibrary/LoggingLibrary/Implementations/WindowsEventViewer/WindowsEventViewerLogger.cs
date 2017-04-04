using LoggingLibrary.Abstractions;
using System;
using System.Diagnostics;

namespace LoggingLibrary.Implementations.WindowsEventViewer
{
  public class WindowsEventViewerLogger : Logger
  {
    private const string LogName = "Application";

    private const string LogSource = "Trencadis";

    public override void Write(LogLevel level, Exception e)
    {
      var exceptionSerializer = new WindowsEventViewerExceptionStringSerializer(level, e, DateTime.Now);

      var exceptionString = exceptionSerializer.GetExceptionString();

      using (EventLog eventLog = new EventLog(WindowsEventViewerLogger.LogName))
      {
        if(!EventLog.SourceExists(WindowsEventViewerLogger.LogSource))
        {
          // This requires user rights elevation
          // Restart VS and run as administrator when creating first time the log source
          EventLog.CreateEventSource(WindowsEventViewerLogger.LogSource, WindowsEventViewerLogger.LogName);
        }

        eventLog.Source = WindowsEventViewerLogger.LogSource;

        eventLog.WriteEntry(exceptionString, this.GetEventLogEntryType(level), this.GetEventID(level));
      }
    }

    protected virtual EventLogEntryType GetEventLogEntryType(LogLevel level)
    {
      switch (level)
      {
        case LogLevel.Warning:
          return EventLogEntryType.Warning;

        case LogLevel.Error:
        case LogLevel.Critical:
          return EventLogEntryType.Error;

        case LogLevel.Unspecified:
        case LogLevel.Debug:
        case LogLevel.Info:
        default:
          return EventLogEntryType.Information;
      }
    }

    protected virtual int GetEventID(LogLevel level)
    {
      return (int)level;
    }
  }
}
