using System;

namespace ProcessApplication
{
  /// <summary>
  /// Represents an exception used to stop a process execution
  /// </summary>
  public class StopProcessException : Exception
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="StopProcessException"/> class
    /// </summary>
    public StopProcessException()
      : base()
    { }

    /// <summary>
    /// Initializes a new instance of the <see cref="StopProcessException"/> class
    /// </summary>
    /// <param name="message">The error message</param>
    public StopProcessException(string message)
      : base(message)
    { }

    /// <summary>
    /// Initializes a new instance of the <see cref="StopProcessException"/> class
    /// </summary>
    /// <param name="message">The error message</param>
    /// <param name="inner">The inner exception</param>
    public StopProcessException(string message, Exception inner)
      : base(message, inner)
    { }
  }
}
