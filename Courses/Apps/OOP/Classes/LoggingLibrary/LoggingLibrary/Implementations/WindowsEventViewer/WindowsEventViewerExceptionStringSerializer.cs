using LoggingLibrary.Helpers;
using System;
using System.Text;

namespace LoggingLibrary.Implementations.WindowsEventViewer
{
  public class WindowsEventViewerExceptionStringSerializer : ExceptionStringSerializer
  {
    public WindowsEventViewerExceptionStringSerializer(LogLevel level, Exception e, DateTime timestamp)
      : base(level, e, timestamp)
    { }

    protected override void SerializeStart(StringBuilder sb)
    { }

    protected override void SerializeHeader(StringBuilder sb)
    { }

    protected override void SerializeEnd(StringBuilder sb)
    { }
  }
}
