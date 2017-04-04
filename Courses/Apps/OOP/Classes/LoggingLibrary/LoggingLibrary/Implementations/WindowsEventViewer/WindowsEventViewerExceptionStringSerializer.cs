using LoggingLibrary.Helpers;
using System;
using System.Text;

namespace LoggingLibrary.Implementations.WindowsEventViewer
{
  /// <summary>
  /// Custom exception serializer adapted for writing to Windows Event Viewer
  /// </summary>
  public class WindowsEventViewerExceptionStringSerializer : ExceptionStringSerializer
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="WindowsEventViewerExceptionStringSerializer"/> class
    /// </summary>
    /// <param name="level">The log level</param>
    /// <param name="e">The exception</param>
    /// <param name="timestamp">The timestamp</param>
    public WindowsEventViewerExceptionStringSerializer(LogLevel level, Exception e, DateTime timestamp)
      : base(level, e, timestamp)
    { }

    /// <summary>
    /// Overrides the serialization start to prevent writing here (we don't need anything to be written for this stage)
    /// </summary>
    /// <param name="sb">The string builder used for serialization</param>
    protected override void SerializeStart(StringBuilder sb)
    { }

    /// <summary>
    /// Overrides the serialization header to prevent writing here (we don't need headers to be written)
    /// </summary>
    /// <param name="sb">The string builder used for serialization</param>
    protected override void SerializeHeader(StringBuilder sb)
    { }

    /// <summary>
    /// Overrides the serialization end to prevent writing here (we don't need anything to be written for this stage)
    /// </summary>
    /// <param name="sb">The string builder used for serialization</param>
    protected override void SerializeEnd(StringBuilder sb)
    { }
  }
}
