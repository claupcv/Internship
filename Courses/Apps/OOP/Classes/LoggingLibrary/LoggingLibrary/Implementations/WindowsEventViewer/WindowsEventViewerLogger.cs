using LoggingLibrary.Abstractions;
using System;
using System.Diagnostics;

namespace LoggingLibrary.Implementations.WindowsEventViewer
{
  /// <summary>
  /// Concrete logger, which writes exceptions to Windows Event Viewer
  /// </summary>
  public class WindowsEventViewerLogger : Logger
  {
    /// <summary>
    /// Holds the log name
    /// </summary>
    private const string LogName = "Application";

    /// <summary>
    /// Holds the log source
    /// </summary>
    private const string LogSource = "Trencadis";

    /// <summary>
    /// Writes an exception to the Windows Event Viewer
    /// </summary>
    /// <param name="level">The log level</param>
    /// <param name="e">The exception</param>
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

    /// <summary>
    /// Translates our <see cref="LogLevel"/> into a corresponding <see cref="EventLogEntryType"/> required by Event Viewer's API
    /// </summary>
    /// <param name="level">The log level</param>
    /// <returns>A <see cref="EventLogEntryType"/> value corresponding to the specified <see cref="LogLevel"/></returns>
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

    /// <summary>
    /// Gets an Event ID (as required by the Event Viewer API) based on the specified <see cref="LogLevel"/>
    /// </summary>
    /// <param name="level">The log level</param>
    /// <returns>An Event ID corresponding to the specified <see cref="LogLevel"/></returns>
    protected virtual int GetEventID(LogLevel level)
    {
      return (int)level;
    }
  }
}
