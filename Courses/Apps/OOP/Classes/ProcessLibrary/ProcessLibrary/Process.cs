using System;

namespace ProcessLibrary
{
  /// <summary>
  /// Abstracts a process
  /// </summary>
  public abstract class Process
  {
    /// <summary>
    /// Gets the process identifier
    /// </summary>
    public abstract int PID { get; }

    /// <summary>
    /// Does initial process validation and returns the validation result
    /// </summary>
    /// <returns>The process validation result</returns>
    protected abstract ProcessResult Validate();

    /// <summary>
    /// Does any pre-processing work and returns the pre-processing result
    /// </summary>
    /// <returns>The process pre-processing result</returns>
    protected virtual ProcessResult OnPreProcessing()
    {
      return ProcessResult.Success();
    }

    /// <summary>
    /// Does the main process work and returns the result
    /// </summary>
    /// <returns>The main process result</returns>
    protected virtual ProcessResult OnProcessing()
    {
      return ProcessResult.Success();
    }

    /// <summary>
    /// Does any post-processing work and returns the post-processing result
    /// </summary>
    /// <returns>The process post-processing result</returns>
    protected virtual ProcessResult OnPostProcessing()
    {
      return ProcessResult.Success();
    }

    /// <summary>
    /// Handles the exceptions that may be thrown during process workflow and returns a corresponding failure result 
    /// </summary>
    /// <param name="e">The exception raised during process execution</param>
    /// <returns>A failed process execution result, modelling the caught error</returns>
    protected virtual ProcessResult OnHandleException(Exception e)
    {
      return ProcessResult.Fail(ProcessingErrorCodes.UnspecifiedError);
    }

    /// <summary>
    /// Executes the process logic and returns the process result
    /// </summary>
    /// <returns>The process execution result</returns>
    public ProcessResult Run()
    {
      try
      {
        var validationResult = this.Validate();
        if (!validationResult.WasSuccessfull)
        {
          // something went wrong on validation
          return validationResult;
        }

        var preProcessingResult = this.OnPreProcessing();
        if(!preProcessingResult.WasSuccessfull)
        {
          // something went wrong on pre-processing
          return preProcessingResult;
        }

        var processingResult = this.OnProcessing();
        if(!processingResult.WasSuccessfull)
        {
          // something went wrong on processing
          return processingResult;
        }

        var postProcessingResult = this.OnPostProcessing();

        // if we reached till here, we can return the result anyway
        return postProcessingResult;
      }
      catch (Exception e)
      {
        var exceptionResult = this.OnHandleException(e);

        return exceptionResult;
      }
    }
  }
}
