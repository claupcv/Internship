using LoggingLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      ApplicationLog.Initialize(LoggerType.WindowsEventViewer);

      Console.WriteLine("Starting app ...");

      try
      {
        // let's suppose we have a real app here
        // and somewhere in the code there is a division by zero exception

        var a = 300;
        var b = 0;
        var calculation = a / b;

        // and code goes on ...
      }
      catch (Exception e)
      {
        ApplicationLog.WriteLog(LogLevel.Error, e);
      }
      finally
      {
        Console.WriteLine("Press any key to close ...");
        Console.ReadKey();
      }
    }
  }
}
