using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exceptions
{
    public static class MultipleExceptions
    {
        public static void MultiExceptionExample()
        {
            try
            {
              string numberAsText = File.ReadAllText(@"D:\temp\test.txt");
              int value = Convert.ToInt32(numberAsText);
            }
            catch (DirectoryNotFoundException)
            {
              Console.WriteLine(@"The specified directory ('D:\temp') was not found");
            }
            catch (FileNotFoundException exFile)
            {
                Console.WriteLine("The specified file '{0}' was not found", exFile.FileName);
            }
            catch(FormatException)
            {
              Console.WriteLine("The read value is in an unsupported format");
            }
            catch(Exception exGeneral)
            {
                Console.WriteLine("OK this is bad, we encountered an unexpected error, message is: {0}", exGeneral.Message);
            }
        }
    }
}
