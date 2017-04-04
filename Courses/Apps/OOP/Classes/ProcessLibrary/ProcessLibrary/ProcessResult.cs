namespace ProcessLibrary
{
  /// <summary>
  /// Represents a process execution result
  /// </summary>
  public class ProcessResult
  {
    // There will be only one kind of successful execution
    // That's why we declare this as static readonly
    private static readonly ProcessResult succesfullExecution = new ProcessResult(true, ProcessingErrorCodes.Success);

    /// <summary>
    /// Gets a flag indicating whether process execution went succesfully
    /// </summary>
    public bool WasSuccessfull
    {
      get;
      private set;
    }

    /// <summary>
    /// Gets a numeric value representing the process error code, in case of execution error(s).
    /// When process execution is succesfull, this property will return <see cref="ProcessingErrorCodes.Success"/>.
    /// </summary>
    public int ErrorCode
    {
      get;
      private set;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ProcessResult"/> class
    /// </summary>
    /// <param name="wasSuccessfull">Flag indicating whether process execution went succesfully</param>
    /// <param name="errorCode">
    /// Numeric value representing the excution error code (in case of errors).
    /// Use <see cref="ProcessingErrorCodes.Success"/> when process executes succesfully
    /// </param>
    private ProcessResult(bool wasSuccessfull, int errorCode)
    {
      this.WasSuccessfull = wasSuccessfull;
      this.ErrorCode = errorCode;
    }

    /// <summary>
    /// Returns a succesfull process execution result
    /// </summary>
    /// <returns>A succesfull process execution result</returns>
    public static ProcessResult Success()
    {
      return ProcessResult.succesfullExecution;
    }

    /// <summary>
    /// Returns a failed process execution result
    /// </summary>
    /// <param name="errorCode">The error code which helps identifying the failure</param>
    /// <returns>A failed process execution result</returns>
    public static ProcessResult Fail(int errorCode)
    {
      if (errorCode == ProcessingErrorCodes.Success)
      {
        // inconsistent
        errorCode = ProcessingErrorCodes.UnspecifiedError;
      }

      return new ProcessResult(false, errorCode);
    }
  }
}
