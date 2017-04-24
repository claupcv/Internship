using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessApp
{
    class ProcessInput
    {
        // FLORIN: Not this class responsibility!
        public abstract void ConsoleInputVerifyInputValue(Person person, string inputLabel, string type);

        // FLORIN: Not this class responsibility!
        public abstract void OutputToConsole(string textOutput);
    }
}
