using System;
using System.Text;

namespace LoggingLibrary.Helpers
{
  public class ExceptionStringSerializer
  {
    public ExceptionStringSerializer(LogLevel level, Exception e, DateTime timestamp)
    {
      this.Exception = e;
      this.Timestamp = timestamp;
      this.Level = level;
    }

    protected Exception Exception
    {
      get;
      private set;
    }

    protected DateTime Timestamp
    {
      get;
      private set;
    }

    protected LogLevel Level
    {
      get;
      private set;
    }

    protected virtual void SerializeStart(StringBuilder sb)
    {
      var separator = new string('-', 80);

      sb.AppendLine(separator);
    }

    protected virtual void SerializeHeader(StringBuilder sb)
    {
      sb.AppendLine($"[{this.Timestamp}] - {this.Level}");
    }

    protected virtual void SerializeException(StringBuilder sb)
    {
      this.SerializeExceptionDetails(sb, this.Exception);
    }

    protected virtual void SerializeExceptionDetails(StringBuilder sb, Exception e)
    {
      if (e == null)
      {
        return;
      }

      var exceptionType = e.GetType();
      var exceptionMessage = e.Message;
      var stackTrace = e.StackTrace;

      sb.AppendLine($"Exception type: {e.GetType()}");
      sb.AppendLine($"Exception message: {e.Message}");
      sb.AppendLine("Stack trace:");
      sb.AppendLine($"{e.StackTrace}");

      if(e.InnerException != null)
      {
        this.SerializeExceptionDetails(sb, e.InnerException);
      }
    }

    protected virtual void SerializeEnd(StringBuilder sb)
    {
      var separator = new string('-', 80);

      sb.AppendLine(separator);
    }

    public string GetExceptionString()
    {
      var stringBuilder = new StringBuilder();

      this.SerializeStart(stringBuilder);

      this.SerializeHeader(stringBuilder);

      this.SerializeException(stringBuilder);

      this.SerializeEnd(stringBuilder);

      return stringBuilder.ToString();
    }
  }
}
