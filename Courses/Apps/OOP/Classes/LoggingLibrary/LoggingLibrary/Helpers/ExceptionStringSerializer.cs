using System;
using System.Text;

namespace LoggingLibrary.Helpers
{
  /// <summary>
  /// Class that realizes exception to string serialization
  /// </summary>
  public class ExceptionStringSerializer
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="ExceptionStringSerializer"/> class
    /// </summary>
    /// <param name="level">The log level</param>
    /// <param name="e">The exception</param>
    /// <param name="timestamp">The error timestamp</param>
    public ExceptionStringSerializer(LogLevel level, Exception e, DateTime timestamp)
    {
      this.Exception = e;
      this.Timestamp = timestamp;
      this.Level = level;
    }

    /// <summary>
    /// Gets the exception to serialize
    /// </summary>
    protected Exception Exception
    {
      get;
      private set;
    }

    /// <summary>
    /// Gets the exception's timestamp
    /// </summary>
    protected DateTime Timestamp
    {
      get;
      private set;
    }

    /// <summary>
    /// Gets the log level associated with the exception
    /// </summary>
    protected LogLevel Level
    {
      get;
      private set;
    }

    /// <summary>
    /// Begins the exception serialization.
    /// By default writes a separator line, override to change this behaviour.
    /// </summary>
    /// <param name="sb">The string builder used for serialization</param>
    protected virtual void SerializeStart(StringBuilder sb)
    {
      var separator = new string('-', 80);

      sb.AppendLine(separator);
    }

    /// <summary>
    /// Serializes the header part.
    /// By default writes the exception timestamp and the log level, override to change this behaviour.
    /// </summary>
    /// <param name="sb">The string builder used for serialization</param>
    protected virtual void SerializeHeader(StringBuilder sb)
    {
      sb.AppendLine($"[{this.Timestamp}] - {this.Level}");
    }

    /// <summary>
    /// Serializes the exception.
    /// By default calls <see cref="SerializeExceptionDetails(StringBuilder, Exception)"/> 
    /// to effectively write the exception's details, override to change this behaviour.
    /// </summary>
    /// <param name="sb">The string builder used for serialization</param>
    protected virtual void SerializeException(StringBuilder sb)
    {
      this.SerializeExceptionDetails(sb, this.Exception);
    }

    /// <summary>
    /// Serializes the specified exception details.
    /// By default writes the exception type, message and stack-trace, 
    /// then recursively tries to parse the inner exception, 
    /// please override if you wish to change this behaviour.
    /// </summary>
    /// <param name="sb">The string builder used for serialization</param>
    /// <param name="e">The exception to parse</param>
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

    /// <summary>
    /// Finishes the exception serialization.
    /// By default writes a separator line, override to change this behaviour.
    /// </summary>
    /// <param name="sb">The string builder used for serialization</param>
    protected virtual void SerializeEnd(StringBuilder sb)
    {
      var separator = new string('-', 80);

      sb.AppendLine(separator);
    }

    /// <summary>
    /// Serializes the exception and returns the corresponding string.
    /// </summary>
    /// <returns>A string representing the serialized exception</returns>
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
