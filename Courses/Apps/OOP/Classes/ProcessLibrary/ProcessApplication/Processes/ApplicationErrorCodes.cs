using ProcessLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessApplication.Processes
{
  /// <summary>
  /// Class holds application-specific error codes
  /// </summary>
  public class ApplicationErrorCodes : ProcessingErrorCodes
  {
    /// <summary>
    /// Error codes specific to the <see cref="WriteStringToConsoleProcess"/> process
    /// </summary>
    public static class WriteStringToConsole
    {
      /// <summary>
      /// Error code to return when text to be written is null
      /// </summary>
      public const int TextIsNull = 100;

      /// <summary>
      /// Error code to return when the text to be written is empty
      /// </summary>
      public const int TextIsEmpty = 101;

      /// <summary>
      /// Error code to return when the text to be written is whitespaces only
      /// </summary>
      public const int TextIsWhitespacesOnly = 102;
    }

    /// <summary>
    /// Error codes specific to the <see cref="WritePersonPropertiesToConsoleProcess"/> process
    /// </summary>
    public static class WritePersonPropertiesToConsole
    {
      /// <summary>
      /// Error code to return when the person instance is null
      /// </summary>
      public const int PersonInstanceIsNull = 200;
    }

    /// <summary>
    /// Error codes specific to the <see cref="WritePersonPropertiesToConsoleWithException"/> process
    /// </summary>
    public static class WritePersonPropertiesToConsoleWithException
    {
      /// <summary>
      /// Error code to return when the process execution was forcibly stopped by throwing a <see cref="StopProcessException"/>
      /// </summary>
      public const int ForceProcessStop = 300;
    }
  }
}
