using ProcessLibrary;
using System;

namespace ProcessApplication.Processes
{
  /// <summary>
  /// Represents the process which writes a person's properties to console and raises an exception
  /// </summary>
  public class WritePersonPropertiesToConsoleWithExceptionProcess : WritePersonPropertiesToConsoleProcess
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="WritePersonPropertiesToConsoleWithExceptionProcess"/> class
    /// </summary>
    /// <param name="person">The person instance</param>
    public WritePersonPropertiesToConsoleWithExceptionProcess(Person person)
      : base(person)
    {

    }

    /// <summary>
    /// Gets the process identifier
    /// </summary>
    public override int PID
    {
      get
      {
        return (int)ProcessIds.WritePersonPropertiesToConsoleWithException;
      }
    }

    /// <summary>
    /// On post-processing phase the process raises an exception to avoid going through the
    /// reporting of the number of person instances written
    /// </summary>
    /// <returns></returns>
    protected override ProcessResult OnPostProcessing()
    {
      // Note: I've written the code in this manner
      // so that we may see that base post-processing won't happen
      // even if it should be called in a "normal" (exception-less) flow
      this.StopProcessingByRaisingAnException();

      // we never reach here:
      return base.OnPostProcessing();
    }

    /// <summary>
    /// Handles exceptions
    /// </summary>
    /// <param name="e">The exception to be handled</param>
    /// <returns>The process execution result corresponding to the caught exception</returns>
    protected override ProcessResult OnHandleException(Exception e)
    {
      if (e is StopProcessException)
      {
        return ProcessResult.Fail(ApplicationErrorCodes.WritePersonPropertiesToConsoleWithException.ForceProcessStop);
      }

      return base.OnHandleException(e);
    }

    /// <summary>
    /// Stops processing by raising an exception
    /// </summary>
    private void StopProcessingByRaisingAnException()
    {
      throw new StopProcessException("Stop processing!");
    }
  }
}
